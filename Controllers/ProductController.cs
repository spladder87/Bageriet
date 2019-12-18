using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bageriet.Models;
using Bageriet.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bageriet.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        // GET: /<controller>/
        public IActionResult List()
        {
            ProductsListViewModel productListViewModel = new ProductsListViewModel();
            productListViewModel.Pies = _productRepository.AllPies;

            productListViewModel.CurrentCategory = "Cheese cakes";
            return View(productListViewModel);
        }
    }
}
