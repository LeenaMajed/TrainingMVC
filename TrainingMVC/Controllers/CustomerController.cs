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
        public IActionResult Search(string searchName, string city)
        {
            var customers = _context.Customers.AsQueryable();

          
            if (!string.IsNullOrEmpty(searchName))
            {
                customers = customers.Where(x =>
                    x.CustomerName.Contains(searchName));
            }

           
            if (!string.IsNullOrEmpty(city))
            {
                customers = customers.Where(x =>
                    x.City.Contains(city));
            }

            return View("Index",customers.ToList());
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

            return View(customer);
        }

        public IActionResult Edit(int id)
        {
            var customers = _context.Customers.Find(id);
            return View(customers);
        }
        
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

        public IActionResult Delete(int id)
        {
            var customer = _context.Customers.Find(id);

            return View(customer);
        }
       
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var customer = _context.Customers.Find(id);

            if (customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
