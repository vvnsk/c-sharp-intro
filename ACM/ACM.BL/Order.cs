using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {
            
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }

        /// <summary>
        ///Retrieve one order
        /// </summary>
        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        /// <summary>
        /// Retrieve all orders
        /// </summary>
        public List<Order> Retrieve()
        {
            return new List<Order>();

        }

        /// <summary>
        /// Saves Current order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;

        }

        /// <summary>
        /// Validates the order data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {

            return OrderDate == null;

        }
    }
}
