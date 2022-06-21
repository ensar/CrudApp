using CrudApp.Data;
using CrudApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Diagnostics;

namespace CrudApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _db;
        public HomeController(DataContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Customer> customers = _db.Customers;
            return View(customers);
        }

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}