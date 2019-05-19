using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {

        /// <summary>
        ///Retrieve one order
        /// </summary>
        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7,0,0));
            }

            return order;
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
    }
}
