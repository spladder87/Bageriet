using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bageriet.Models;

namespace Bageriet.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
