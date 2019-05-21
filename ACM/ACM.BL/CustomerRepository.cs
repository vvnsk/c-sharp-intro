using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            AddressRepository = new AddressRepository();
        }
        private  AddressRepository AddressRepository { get; set; }

        /// <summary>
        /// Retrieve one customer
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.FirstName = "Foo";
                customer.LastName = "Bar";
                customer.EmailAddress = "foo@bar.com";
                customer.AddressList = AddressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;

        }

        /// <summary>
        /// Retrieve all customers
        /// </summary>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();

        }

        /// <summary>
        /// Saves Current Customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;

        }
    }
}
