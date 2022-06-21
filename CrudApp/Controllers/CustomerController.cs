using CrudApp.Data;
using CrudApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly DataContext _db;
        public CustomerController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }
            _db.Customers.Add(customer);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Customer user=_db.Customers.FirstOrDefault(x => x.Id == id);
            if(user is not null)
            {
                return View(user);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }
            Customer user=_db.Customers.FirstOrDefault(x => x.Id == customer.Id);
            user.CustomerName = customer.CustomerName;
            user.CustomerJob = customer.CustomerJob;
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            Customer user= _db.Customers.FirstOrDefault(x => x.Id == id);
            return View(user);
        }

        [HttpPost]
        public IActionResult Remove(Customer customer)
        {
            Customer user= _db.Customers.FirstOrDefault(x => x.Id == customer.Id);
            _db.Customers.Remove(user);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
