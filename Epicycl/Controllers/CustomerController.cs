using Epicycl.Models;
using Epicycl.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Linq;

namespace Epicycl.Controllers
{
    public class CustomerController : Controller
    {
        
        public ActionResult Index()
        {
            
            var customers = GetCustomers();
            
            
            return View(customers);
        }



        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(x=> x.Id == id);
            
            if(customer != null)
            {
                
                return View(customer);
            }
            else
            {
                return NotFound();
            }
        }
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
            new Customer { Id= 0, Name = "Jonas Jonaitis"},
            new Customer { Id= 1, Name = "Marytė Marytaitė"}
            };
        }
    }
}
