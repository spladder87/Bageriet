using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bageriet.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllPies { get; }
        IEnumerable<Product> ProductsOfTheWeek { get; }
        Product GetPieById(int pieId);
    }
}
