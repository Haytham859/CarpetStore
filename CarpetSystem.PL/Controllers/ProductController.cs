using CarpetSystem.BLL.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace CarpetSystem.PL.Controllers
{
    public class ProductController:Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {


            return View();
        }

    }
}
