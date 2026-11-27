
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using dbCustomer = BikeStore.Customer;

namespace BikeStore.Classes
{
    public class Customer : Person
    {
        public int CustomerId { get; private set; }
        public string Title { get; set; }

        public string Suffix { get; set; }

        public string CompanyName { get; set; }

        public string SalesPerson { get; set; }

        public bool NameStyle { get; set; }

        public DateTime ModifiedDate { get; private set; }

        public List<CustomerAddressInfo> Addresses { get; private set; } = new List<CustomerAddressInfo>();

        public Customer()
        {
            CustomerId = 0;
            NameStyle = false;
        }


        public static List<Customer> GetCustomers()
        {
            using (BikeStoreEntities db = new BikeStoreEntities())
            {
                List<Customer> customers = new List<Customer>();

                var dbCustomers = db.Customers
                    .OrderBy(c => c.CustomerID)
                    .ToList();

                foreach (var record in dbCustomers)
                {
                    Customer customer = new Customer();

                    customer.LoadCustomerInfo(record);

                    customers.Add(customer);
                }

                return customers;
            }
        }


        public void GetCustomerByID(int customerId)
        {
            using (BikeStoreEntities db = new BikeStoreEntities())
            {
                dbCustomer customer = db.Customers.FirstOrDefault(c => c.CustomerID == customerId);

                if (customer == null)
                {
                    throw new Exception("Customer not found.");
                }

                LoadCustomerInfo(customer);
            }
        }


        private void LoadCustomerInfo(dbCustomer customer)
        {
            CustomerId = customer.CustomerID;

            NameStyle = customer.NameStyle;

            Title = customer.Title;

            FirstName = customer.FirstName;

            MiddleName = customer.MiddleName;

            LastName = customer.LastName;

            Suffix = customer.Suffix;

            CompanyName = customer.CompanyName;

            SalesPerson = customer.SalesPerson;

            EmailAddress = customer.EmailAddress;

            Phone = customer.Phone;

            ModifiedDate = customer.ModifiedDate;
        }

        public void AddCustomer()
        {
            ValidateCustomerInfo();

            if (Addresses == null || Addresses.Count == 0)
            {
                throw new Exception(
                    "Please add at least one address before saving the customer.");
            }

            foreach (CustomerAddressInfo address in Addresses)
            {
                if (string.IsNullOrWhiteSpace(address.AddressType) ||
                    string.IsNullOrWhiteSpace(address.AddressLine1) ||
                    string.IsNullOrWhiteSpace(address.City) ||
                    string.IsNullOrWhiteSpace(address.StateProvince) ||
                    string.IsNullOrWhiteSpace(address.CountryRegion) ||
                    string.IsNullOrWhiteSpace(address.PostalCode))
                {
                    throw new Exception(
                        "Please complete all required fields for every address.");
                }
            }

            using (BikeStoreEntities db = new BikeStoreEntities())
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    // Create customer
                    dbCustomer customer = new dbCustomer();

                    customer.NameStyle = NameStyle;
                    customer.Title = Title;
                    customer.FirstName = FirstName;
                    customer.MiddleName = MiddleName;
                    customer.LastName = LastName;
                    customer.Suffix = Suffix;
                    customer.CompanyName = CompanyName;
                    customer.SalesPerson = SalesPerson;
                    customer.EmailAddress = EmailAddress;
                    customer.Phone = Phone;

                    // Required AdventureWorks customer fields
                    string password = Guid.NewGuid().ToString("N");
                    string salt = BCrypt.Net.BCrypt.GenerateSalt();

                    customer.PasswordHash =
                        BCrypt.Net.BCrypt.HashPassword(password, salt);

                    customer.PasswordSalt = salt.Substring(0, 10);
                    customer.rowguid = Guid.NewGuid();
                    customer.ModifiedDate = DateTime.Now;

                    db.Customers.Add(customer);

                    // Generate CustomerID
                    db.SaveChanges();

                    // Save each address and its customer relationship
                    foreach (CustomerAddressInfo addressInfo in Addresses)
                    {
                        Address address = new Address
                        {
                            AddressLine1 = addressInfo.AddressLine1,
                            AddressLine2 = addressInfo.AddressLine2,
                            City = addressInfo.City,
                            StateProvince = addressInfo.StateProvince,
                            CountryRegion = addressInfo.CountryRegion,
                            PostalCode = addressInfo.PostalCode,
                            rowguid = Guid.NewGuid(),
                            ModifiedDate = DateTime.Now
                        };

                        db.Addresses.Add(address);
                        db.SaveChanges();

                        CustomerAddress customerAddress =
                            new CustomerAddress
                            {
                                CustomerID = customer.CustomerID,
                                AddressID = address.AddressID,
                                AddressType = addressInfo.AddressType,
                                rowguid = Guid.NewGuid(),
                                ModifiedDate = DateTime.Now
                            };

                        db.CustomerAddresses.Add(customerAddress);
                    }

                    db.SaveChanges();

                    // Commit customer and addresses together
                    transaction.Commit();

                    LoadCustomerInfo(customer);
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void UpdateCustomer()
        {
            ValidateCustomerInfo();

            // Require at least one address
            if (Addresses == null || Addresses.Count == 0)
            {
                throw new Exception(
                    "Please add at least one address before saving.");
            }

            // Validate all addresses
            foreach (CustomerAddressInfo info in Addresses)
            {
                if (string.IsNullOrWhiteSpace(info.AddressType) ||
                    string.IsNullOrWhiteSpace(info.AddressLine1) ||
                    string.IsNullOrWhiteSpace(info.City) ||
                    string.IsNullOrWhiteSpace(info.StateProvince) ||
                    string.IsNullOrWhiteSpace(info.CountryRegion) ||
                    string.IsNullOrWhiteSpace(info.PostalCode))
                {
                    throw new Exception(
                        "Please complete all required address fields.");
                }
            }

            using (BikeStoreEntities db = new BikeStoreEntities())
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    dbCustomer customer = db.Customers
                        .FirstOrDefault(c => c.CustomerID == CustomerId);

                    if (customer == null)
                        throw new Exception("Customer not found.");

                    // Update customer information
                    customer.NameStyle = NameStyle;
                    customer.Title = Title;
                    customer.FirstName = FirstName;
                    customer.MiddleName = MiddleName;
                    customer.LastName = LastName;
                    customer.Suffix = Suffix;
                    customer.CompanyName = CompanyName;
                    customer.SalesPerson = SalesPerson;
                    customer.EmailAddress = EmailAddress;
                    customer.Phone = Phone;
                    customer.ModifiedDate = DateTime.Now;

                    // Get current customer-address relationships
                    var existingLinks = db.CustomerAddresses
                        .Where(ca => ca.CustomerID == CustomerId)
                        .ToList();

                    // Remove relationships deleted from the form
                    foreach (var link in existingLinks)
                    {
                        bool stillExists = Addresses.Any(a =>
                            a.AddressId == link.AddressID);

                        if (!stillExists)
                        {
                            db.CustomerAddresses.Remove(link);
                        }
                    }

                    // Add or update addresses
                    foreach (CustomerAddressInfo info in Addresses)
                    {
                        if (info.AddressId == 0)
                        {
                            // New address
                            Address newAddress = new Address
                            {
                                AddressLine1 = info.AddressLine1,
                                AddressLine2 = info.AddressLine2,
                                City = info.City,
                                StateProvince = info.StateProvince,
                                CountryRegion = info.CountryRegion,
                                PostalCode = info.PostalCode,
                                rowguid = Guid.NewGuid(),
                                ModifiedDate = DateTime.Now
                            };

                            db.Addresses.Add(newAddress);
                            db.SaveChanges();

                            // Create customer-address relationship
                            CustomerAddress newLink = new CustomerAddress
                            {
                                CustomerID = CustomerId,
                                AddressID = newAddress.AddressID,
                                AddressType = info.AddressType,
                                rowguid = Guid.NewGuid(),
                                ModifiedDate = DateTime.Now
                            };

                            db.CustomerAddresses.Add(newLink);
                        }
                        else
                        {
                            // Existing address
                            var link = existingLinks.FirstOrDefault(
                                ca => ca.AddressID == info.AddressId);

                            if (link == null)
                            {
                                throw new Exception(
                                    "Address relationship not found.");
                            }

                            Address address = db.Addresses
                                .FirstOrDefault(a =>
                                    a.AddressID == info.AddressId);

                            if (address == null)
                            {
                                throw new Exception("Address not found.");
                            }

                            // Check whether another customer uses this address
                            bool isShared = db.CustomerAddresses.Any(ca =>
                                ca.AddressID == info.AddressId &&
                                ca.CustomerID != CustomerId);

                            if (isShared)
                            {
                                // Create a separate address to avoid
                                // modifying another customer's information
                                Address replacement = new Address
                                {
                                    AddressLine1 = info.AddressLine1,
                                    AddressLine2 = info.AddressLine2,
                                    City = info.City,
                                    StateProvince = info.StateProvince,
                                    CountryRegion = info.CountryRegion,
                                    PostalCode = info.PostalCode,
                                    rowguid = Guid.NewGuid(),
                                    ModifiedDate = DateTime.Now
                                };

                                db.Addresses.Add(replacement);
                                db.SaveChanges();

                                // Replace the relationship
                                db.CustomerAddresses.Remove(link);

                                db.CustomerAddresses.Add(
                                    new CustomerAddress
                                    {
                                        CustomerID = CustomerId,
                                        AddressID = replacement.AddressID,
                                        AddressType = info.AddressType,
                                        rowguid = Guid.NewGuid(),
                                        ModifiedDate = DateTime.Now
                                    });
                            }
                            else
                            {
                                // Update existing address
                                address.AddressLine1 = info.AddressLine1;
                                address.AddressLine2 = info.AddressLine2;
                                address.City = info.City;
                                address.StateProvince = info.StateProvince;
                                address.CountryRegion = info.CountryRegion;
                                address.PostalCode = info.PostalCode;
                                address.ModifiedDate = DateTime.Now;

                                // Update relationship type
                                link.AddressType = info.AddressType;
                                link.ModifiedDate = DateTime.Now;
                            }
                        }
                    }

                    // Save all changes
                    db.SaveChanges();

                    // Commit everything together
                    transaction.Commit();

                    LoadCustomerInfo(customer);
                    LoadAddresses();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void DeleteCustomer()
        {
            using (BikeStoreEntities db = new BikeStoreEntities())
            {
                dbCustomer customer = db.Customers
                    .FirstOrDefault(c => c.CustomerID == CustomerId);

                if (customer == null)
                {
                    throw new Exception("Customer not found.");
                }

                // Check if customer has existing orders
                bool hasOrders = db.SalesOrderHeaders
                    .Any(o => o.CustomerID == CustomerId);

                if (hasOrders)
                {
                    throw new Exception(
                        "This customer cannot be deleted because " +
                        "they have existing sales orders.");
                }

                // Check if customer has associated addresses
                bool hasAddresses = db.CustomerAddresses
                    .Any(a => a.CustomerID == CustomerId);

                if (hasAddresses)
                {
                    throw new Exception(
                        "This customer cannot be deleted because " +
                        "they have associated addresses.");
                }

                db.Customers.Remove(customer);

                db.SaveChanges();

                CustomerId = 0;
            }
        }



        public static List<Customer> SearchCustomers(string customerId = "", string firstName = "", string middleName = "", string lastName = "", string companyName = "", string address = "", string emailAddress = "")
        {
            using (BikeStoreEntities db = new BikeStoreEntities())
            {
                var query = db.Customers.AsQueryable();

                // Search by Customer ID
                if (!string.IsNullOrWhiteSpace(customerId))
                {
                    int id;

                    if (!int.TryParse(customerId.Trim(), out id))
                    {
                        return new List<Customer>();
                    }

                    query = query.Where(c => c.CustomerID == id);
                }

                // Search by First Name
                if (!string.IsNullOrWhiteSpace(firstName))
                {
                    string value = firstName.Trim();

                    query = query.Where(c =>
                        c.FirstName.Contains(value));
                }

                // Search by Middle Name
                if (!string.IsNullOrWhiteSpace(middleName))
                {
                    string value = middleName.Trim();

                    query = query.Where(c =>
                        c.MiddleName != null &&
                        c.MiddleName.Contains(value));
                }

                // Search by Last Name
                if (!string.IsNullOrWhiteSpace(lastName))
                {
                    string value = lastName.Trim();

                    query = query.Where(c =>
                        c.LastName.Contains(value));
                }

                // Search by Company Name
                if (!string.IsNullOrWhiteSpace(companyName))
                {
                    string value = companyName.Trim();

                    query = query.Where(c =>
                        c.CompanyName != null &&
                        c.CompanyName.Contains(value));
                }

                // Search all customer street addresses
                if (!string.IsNullOrWhiteSpace(address))
                {
                    string value = address.Trim();

                    query = query.Where(c =>
                        db.CustomerAddresses.Any(ca =>
                            ca.CustomerID == c.CustomerID &&
                            db.Addresses.Any(a =>
                                a.AddressID == ca.AddressID &&
                                (
                                    a.AddressLine1.Contains(value) ||
                                    (a.AddressLine2 != null &&
                                     a.AddressLine2.Contains(value))
                                )
                            )
                        )
                    );
                }

                // Search by Email Address
                if (!string.IsNullOrWhiteSpace(emailAddress))
                {
                    string value = emailAddress.Trim();

                    query = query.Where(c =>
                        c.EmailAddress != null &&
                        c.EmailAddress.Contains(value));
                }

                // Retrieve matching customers
                var dbCustomers = query
                    .OrderBy(c => c.CustomerID)
                    .ToList();

                // Convert database entities to Customer objects
                List<Customer> customers = new List<Customer>();

                foreach (dbCustomer record in dbCustomers)
                {
                    Customer customer = new Customer();

                    customer.LoadCustomerInfo(record);

                    customers.Add(customer);
                }

                return customers;
            }
        }


        private void ValidateCustomerInfo()
        {
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                throw new Exception("First name is required.");
            }

            if (string.IsNullOrWhiteSpace(LastName))
            {
                throw new Exception("Last name is required.");
            }

            if (FirstName.Length > 50)
            {
                throw new Exception("First name cannot exceed 50 characters.");
            }

            if (LastName.Length > 50)
            {
                throw new Exception("Last name cannot exceed 50 characters.");
            }

            if (!string.IsNullOrWhiteSpace(EmailAddress))
            {
                try
                {
                    var email = new System.Net.Mail.MailAddress(EmailAddress);

                    if (email.Address != EmailAddress)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    throw new Exception("Invalid email address.");
                }
            }

            FirstName = FirstName.Trim();
            LastName = LastName.Trim();

            MiddleName = string.IsNullOrWhiteSpace(MiddleName) ? null : MiddleName.Trim();

            EmailAddress = string.IsNullOrWhiteSpace(EmailAddress) ? null : EmailAddress.Trim();

            Phone = string.IsNullOrWhiteSpace(Phone) ? null : Phone.Trim();

            CompanyName = string.IsNullOrWhiteSpace(CompanyName) ? null : CompanyName.Trim();
        }

        private static Dictionary<int, string> GetCustomerAddresses(BikeStoreEntities db, List<int> customerIds)
        {
            var addresses =
                (from ca in db.CustomerAddresses
                 join a in db.Addresses
                     on ca.AddressID equals a.AddressID
                 where customerIds.Contains(ca.CustomerID)
                 orderby ca.CustomerID, ca.AddressID
                 select new
                 {
                     ca.CustomerID,
                     a.AddressLine1,
                     a.City,
                     a.StateProvince
                 }).ToList();

            return addresses
                .GroupBy(a => a.CustomerID)
                .ToDictionary(
                    g => g.Key,
                    g => string.Join("; ", g.Select(a =>
                        string.Join(", ", new[]
                        {
                    a.AddressLine1,
                    a.City,
                    a.StateProvince
                        }.Where(s => !string.IsNullOrWhiteSpace(s))))
                    )
                );
        }

    public void LoadAddresses()
        {
            using (BikeStoreEntities db = new BikeStoreEntities())
            {
                Addresses = (
                    from ca in db.CustomerAddresses
                    join a in db.Addresses
                        on ca.AddressID equals a.AddressID
                    where ca.CustomerID == CustomerId
                    select new CustomerAddressInfo
                    {
                        AddressId = a.AddressID,
                        AddressType = ca.AddressType,
                        AddressLine1 = a.AddressLine1,
                        AddressLine2 = a.AddressLine2,
                        City = a.City,
                        StateProvince = a.StateProvince,
                        CountryRegion = a.CountryRegion,
                        PostalCode = a.PostalCode
                    }
                ).ToList();
            }
        }
    }
}