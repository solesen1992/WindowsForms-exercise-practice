using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_NotSoCoolShop.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<OrderLine> OrderLines { get; set; } // What orderlines this product is a part of
        public decimal Price { get; set; } // More precise than double

        public override string ToString()
        {
            return Title + " (" + Price + ")";
        }
    }
}
