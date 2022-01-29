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

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };
            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }
            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
               var customerInDb = _context.Customers.Single(x => x.Id == customer.Id);
               customerInDb.Name = customer.Name;
               customerInDb.Birthday = customer.Birthday;
               customerInDb.MembershipTypeId = customer.MembershipTypeId;
               customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }
            
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == id);
            if (customer == null)
            {
                return RedirectToAction("Index", "Home");
            }
            
            
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("CustomerForm", viewModel); // sitas nukelia tiesiai i View.New kad butu sukurtas varototojas jei tokio nerado
            
            
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
