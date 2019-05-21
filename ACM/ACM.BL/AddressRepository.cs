using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class AddressRepository
    {

        /// <summary>
        /// Retrieve one address
        /// </summary>
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType =1;
                address.StreetLine1 = "Foo Bar";
                address.StreetLine2 = "Foo Bar Loreum";
                address.City = "Kingslanding";
                address.Country = "Westros";
                address.PostalCode = "123";
            }

            return address;

        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Foo Bar",
                StreetLine2 = "Foo Bar Loreum",
                City = "Kingslanding",
                Country = "Westros",
                PostalCode = "123"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Boo Far",
                StreetLine2 = "Boo Far Loreum",
                City = "Winterfell",
                Country = "Westros",
                PostalCode = "456"
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Retrieve all Addresses
        /// </summary>
        public List<Address> Retrieve()
        {
            return new List<Address>();

        }

        /// <summary>
        /// Saves Current Address
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;

        }
    }
}
