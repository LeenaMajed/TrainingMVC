using Microsoft.AspNetCore.Mvc;
using TrainingMVC.Models;

namespace TrainingMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductViewModel()
        {
            List<ProductViewModel> product = new List<ProductViewModel>();

            product.Add(new ProductViewModel
            {
                ProductID = 1,
                ProductName = "Phone",
                Price = 100.5m,
                Quantity = 1,
                Category = "Electronics"
            });

            product.Add(new ProductViewModel
            {
                ProductID = 2,
                ProductName = "Laptop",
                Price = 550.75m,
                Quantity = 2,
                Category = "Electronics"
            });

            product.Add(new ProductViewModel
            {
                ProductID = 3,
                ProductName = "Headphones",
                Price = 25.99m,
                Quantity = 3,
                Category = "Accessories"
            });

            product.Add(new ProductViewModel
            {
                ProductID = 4,
                ProductName = "Keyboard",
                Price = 45.50m,
                Quantity = 4,
                Category = "Computer Parts"
            });

            product.Add(new ProductViewModel
            {
                ProductID = 5,
                ProductName = "Smart Watch",
                Price = 120.00m,
                Quantity = 2,
                Category = "Wearables"
            });
            product.Add(new ProductViewModel
            {
                ProductID = 6,
                ProductName = "Hard Disk",
                Price = 55.50m,
                Quantity = 3,
                Category = "Computer Parts"
            });
            return View(product);
        }
    }
}
