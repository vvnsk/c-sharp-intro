using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {

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
