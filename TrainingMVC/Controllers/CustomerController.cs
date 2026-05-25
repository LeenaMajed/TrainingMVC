using Microsoft.AspNetCore.Mvc;
using TrainingMVC.Data;

namespace TrainingMVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }
        public IActionResult Details(int id)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.CustomerID==id);
            return View(customer);
        }

    }
}
