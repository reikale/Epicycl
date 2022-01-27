using Epicycl.Models;
using Epicycl.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;

namespace Epicycl.Controllers
{
    public class CustomerController : Controller
    {
        private DataContext _context;
        public CustomerController(DataContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            
            var customers = _context.Customers.Include(c => c.MembershipType);
            
            
            return View(customers);
        }



        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == id);

            if (customer != null)
            {

                return View(customer);
            }
            else
            {
                return NotFound();
            }
        }

    }
}
