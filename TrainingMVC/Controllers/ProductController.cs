using Microsoft.AspNetCore.Mvc;
using TrainingMVC.Data;
using TrainingMVC.Models;

namespace TrainingMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductViewModel()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
    }
}
