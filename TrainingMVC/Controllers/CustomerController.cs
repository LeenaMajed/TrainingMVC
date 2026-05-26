using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrainingMVC.Data;
using TrainingMVC.Models;

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
        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer customer )
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Add(customer);

                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(int id)
        {
            var customers = _context.Customers.Find(id);
            return View(customers);
        }
        [HttpPost]
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                var existing = _context.Customers.Find(customer.CustomerID);

                if (existing == null)
                {
                    return NotFound();
                }

                existing.CustomerName = customer.CustomerName;
                existing.MobileNo = customer.MobileNo;
                existing.Email = customer.Email;
                existing.City = customer.City;

                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(customer);
        }


    }
}
