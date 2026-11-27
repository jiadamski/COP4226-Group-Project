using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStore.Classes
{
    public class CustomerAddressInfo
    {
        public int AddressId { get; set; }

        public string AddressType { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string StateProvince { get; set; }

        public string CountryRegion { get; set; }

        public string PostalCode { get; set; }

        public string FullAddress
        {
            get
            {
                return string.Join(", ", new[]
                {
                    AddressLine1,
                    AddressLine2,
                    City,
                    StateProvince,
                    PostalCode,
                    CountryRegion
                }.Where(s => !string.IsNullOrWhiteSpace(s)));
            }
        }
    }
}