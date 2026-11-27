using System;
using System.Collections.Generic;
using System.Linq;

namespace BikeStore.Classes
{
    public class Order
    {
        public int SalesOrderID { get; set; }
        public string SalesOrderNumber { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public string Status { get; set; }
        public decimal TotalDue { get; set; }

        // Constructor for a new order
        public Order()
        {
            OrderDate = DateTime.Now;
            DueDate = DateTime.Now.AddDays(7);
            Status = "In Process";
            TotalDue = 0;
        }

        // Constructor for an existing order
        public Order(int salesOrderId) : this()
        {
            LoadOrder(salesOrderId);
        }

        // Load one existing order
        public void LoadOrder(int salesOrderId)
        {
            using (BikeStoreEntities db = new BikeStoreEntities())
            {
                var order = (
                    from o in db.SalesOrderHeaders
                    join c in db.Customers
                        on o.CustomerID equals c.CustomerID
                    where o.SalesOrderID == salesOrderId
                    select new
                    {
                        o.SalesOrderID,
                        o.SalesOrderNumber,
                        c.FirstName,
                        c.MiddleName,
                        c.LastName,
                        o.OrderDate,
                        o.DueDate,
                        o.ShipDate,
                        o.Status,
                        o.TotalDue
                    }).FirstOrDefault();

                if (order == null)
                    throw new Exception("Order not found.");

                SalesOrderID = order.SalesOrderID;
                SalesOrderNumber = order.SalesOrderNumber;

                CustomerName = string.Join(" ", new[]
                {
                    order.FirstName,
                    order.MiddleName,
                    order.LastName
                }.Where(n => !string.IsNullOrWhiteSpace(n)));

                OrderDate = order.OrderDate;
                DueDate = order.DueDate;
                ShipDate = order.ShipDate;
                Status = GetStatusDescription(order.Status);
                TotalDue = order.TotalDue;
            }
        }

        // Retrieve all orders
        public static List<Order> GetOrders()
        {
            using (BikeStoreEntities db = new BikeStoreEntities())
            {
                var orders = (
                    from order in db.SalesOrderHeaders
                    join customer in db.Customers
                        on order.CustomerID equals customer.CustomerID
                    select new
                    {
                        order.SalesOrderID,
                        order.SalesOrderNumber,
                        customer.FirstName,
                        customer.MiddleName,
                        customer.LastName,
                        order.OrderDate,
                        order.DueDate,
                        order.ShipDate,
                        order.Status,
                        order.TotalDue
                    }).ToList();

                return orders.Select(o => new Order
                {
                    SalesOrderID = o.SalesOrderID,
                    SalesOrderNumber = o.SalesOrderNumber,

                    CustomerName = string.Join(" ", new[]
                    {
                        o.FirstName,
                        o.MiddleName,
                        o.LastName
                    }.Where(n => !string.IsNullOrWhiteSpace(n))),

                    OrderDate = o.OrderDate,
                    DueDate = o.DueDate,
                    ShipDate = o.ShipDate,
                    Status = GetStatusDescription(o.Status),
                    TotalDue = o.TotalDue
                })
                .OrderByDescending(o => o.OrderDate)
                .ToList();
            }
        }

        public static List<Order> SearchOrders(
            string orderNumber,
            string customerName,
            byte? status,
            DateTime? dateFrom,
            DateTime? dateTo)
        {
            using (BikeStoreEntities db = new BikeStoreEntities())
            {
                var query =
                    from order in db.SalesOrderHeaders.AsNoTracking()
                    join customer in db.Customers.AsNoTracking()
                        on order.CustomerID equals customer.CustomerID
                    select new { order, customer };

                // Partial order number search
                if (!string.IsNullOrWhiteSpace(orderNumber))
                {
                    string value = orderNumber.Trim();

                    query = query.Where(x =>
                        x.order.SalesOrderNumber.Contains(value));
                }

                // Partial customer name search
                if (!string.IsNullOrWhiteSpace(customerName))
                {
                    string value = customerName.Trim();

                    query = query.Where(x =>
                        (x.customer.FirstName + " " +
                         x.customer.LastName).Contains(value) ||
                        x.customer.FirstName.Contains(value) ||
                        x.customer.LastName.Contains(value));
                }

                // Exact status search
                if (status.HasValue)
                {
                    query = query.Where(x =>
                        x.order.Status == status.Value);
                }

                // Date range
                if (dateFrom.HasValue)
                {
                    DateTime start = dateFrom.Value.Date;

                    query = query.Where(x =>
                        x.order.OrderDate >= start);
                }

                if (dateTo.HasValue)
                {
                    DateTime endExclusive = dateTo.Value.Date.AddDays(1);

                    query = query.Where(x =>
                        x.order.OrderDate < endExclusive);
                }

                return query
                    .OrderByDescending(x => x.order.OrderDate)
                    .ToList()
                    .Select(x => new Order
                    {
                        SalesOrderID = x.order.SalesOrderID,
                        SalesOrderNumber = x.order.SalesOrderNumber,
                        CustomerName = string.Join(" ", new[]
                        {
                    x.customer.FirstName,
                    x.customer.MiddleName,
                    x.customer.LastName
                        }.Where(n => !string.IsNullOrWhiteSpace(n))),
                        OrderDate = x.order.OrderDate,
                        DueDate = x.order.DueDate,
                        ShipDate = x.order.ShipDate,
                        Status = GetStatusDescription(x.order.Status),
                        TotalDue = x.order.TotalDue
                    })
                    .ToList();
            }
        }

        // Convert status code into readable text
        public static string GetStatusDescription(byte status)
        {
            switch (status)
            {
                case 1: return "In Process";
                case 2: return "Approved";
                case 3: return "Backordered";
                case 4: return "Rejected";
                case 5: return "Shipped";
                case 6: return "Cancelled";
                default: return "Unknown";
            }
        }

        public static void UpdateOrderStatus(int salesOrderId, byte newStatus)
        {
            if (newStatus < 1 || newStatus > 6)
                throw new ArgumentOutOfRangeException(nameof(newStatus));

            using (var db = new BikeStoreEntities())
            {
                var order = db.SalesOrderHeaders
                    .FirstOrDefault(o => o.SalesOrderID == salesOrderId);

                if (order == null)
                    throw new InvalidOperationException("Order not found.");

                order.Status = newStatus;

                if (newStatus == 5 && !order.ShipDate.HasValue)
                    order.ShipDate = DateTime.Today;

                order.ModifiedDate = DateTime.Now;

                db.SaveChanges();
            }
        }

        public static void DeleteOrder(int salesOrderId)
        {
            using (BikeStoreEntities db = new BikeStoreEntities())
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    var order = db.SalesOrderHeaders
                        .FirstOrDefault(o => o.SalesOrderID == salesOrderId);

                    if (order == null)
                        throw new InvalidOperationException("Order not found.");

                    var details = db.SalesOrderDetails
                        .Where(d => d.SalesOrderID == salesOrderId)
                        .ToList();

                    db.SalesOrderDetails.RemoveRange(details);
                    db.SalesOrderHeaders.Remove(order);

                    db.SaveChanges();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}