using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_NotSoCoolShop.Domain
{
    public class Customer
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Order> Orders { get; set; } // The customer can make more than one order

        // Constructor
        public Customer() { 
            Orders = new List<Order>();
        }
    }
}