using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_NotSoCoolShop.Domain
{
    public class Order
    {
        // Properties
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderLine> OrderLines { get; set; } // An order contains a lot of orderlines
        public Customer Customer { get; set; } // The order belongs to a customer

        // Constructor
        public Order() { 
            OrderLines = new List<OrderLine>();
        }
    }
}
