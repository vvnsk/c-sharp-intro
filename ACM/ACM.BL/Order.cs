using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace ACM.BL
{
    public class Order: EntityBase, ILoggable
    {
        public Order(): this(0)
        {
            
        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        private int OrderId { get; set; }

        public string Log() => $"{OrderId}: OrderDate: {OrderDate} Status: {EntityState.ToString()}";
        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";

        /// <summary>
        /// Validates the order data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            return OrderDate == null;

        }
    }
}
