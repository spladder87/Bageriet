using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public class ProductsContext
    {
        public List<Product> Products { get; set; }
        public ProductsContext()
        {
            this.Products = new List<Product>();
            this.Products.Add(new Product("Kanelbulle"));
            this.Products.Add(new Product("Fralla"));
            this.Products.Add(new Product("Wienerbröd"));

        }

       
    }
}
