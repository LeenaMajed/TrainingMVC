using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrainingMVC.Models;

namespace TrainingMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Training()
        {
            return View();
        }
        public IActionResult Product()
        {
            List<Product> product = new List<Product>();

            product.Add(new Product
            {
                ProductID = 1,
                ProductName = "Phone",
                Price = 100.5m,
                Quantity = 1,
                Category = "Electronics"
            });

            product.Add(new Product
            {
                ProductID = 2,
                ProductName = "Laptop",
                Price = 550.75m,
                Quantity = 2,
                Category = "Electronics"
            });

            product.Add(new Product
            {
                ProductID = 3,
                ProductName = "Headphones",
                Price = 25.99m,
                Quantity = 3,
                Category = "Accessories"
            });

            product.Add(new Product
            {
                ProductID = 4,
                ProductName = "Keyboard",
                Price = 45.50m,
                Quantity = 4,
                Category = "Computer Parts"
            });

            product.Add(new Product
            {
                ProductID = 5,
                ProductName = "Smart Watch",
                Price = 120.00m,
                Quantity = 2,
                Category = "Wearables"
            });
            return View(product);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
