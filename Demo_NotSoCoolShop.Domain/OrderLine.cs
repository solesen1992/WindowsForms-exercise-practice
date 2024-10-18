using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_NotSoCoolShop.Domain
{
    public class OrderLine
    {
        public Product Product { get; set; }
        public int Amount { get; set; }
        public Order Order { get; set; } // Which order this orderline is a part of
    }
}
