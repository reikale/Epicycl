using Epicycl.Models;
using Epicycl.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNetCore.Authorization;

namespace Epicycl.Controllers
{
    public class CustomerController : Controller
    {
        private DataContext _context;
        public CustomerController(DataContext context)
        {
            _context = context;
        }


        [Microsoft.AspNetCore.Authorization.Authorize]
        public ActionResult Index()
        {

            var customers = _context.Customers.Include(c => c.MembershipType);
            


            return View(customers);

        }

        
        [Microsoft.AspNetCore.Authorization.Authorize(Roles= "ServiceProvider, AdminUser")]
        public ActionResult New()
        {
            var membershipTypes = _context.SubscribtionTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };
            return View("CustomerForm", viewModel);
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        /*[ValidateAntiForgeryToken]*/
        public ActionResult Save(Customer customer)
        {
                        
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.SubscribtionTypes.ToList()
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

        [Microsoft.AspNetCore.Authorization.Authorize(Roles = "AdminUser")]
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
                MembershipTypes = _context.SubscribtionTypes.ToList()
            };
            return View("CustomerForm", viewModel); // sitas nukelia tiesiai i View.New kad butu sukurtas varototojas jei tokio nerado
            
            
        }
        [Microsoft.AspNetCore.Authorization.Authorize(Roles = "AdminUser")]
        public ActionResult DeleteCustomer(int id)
        {
            if (id != null)
            {
                var customer = _context.Customers.SingleOrDefault(x=> x.Id == id);
                if (customer == null)
                {
                    throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
                }
                _context.Customers.Remove(customer);
               
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }

        [Microsoft.AspNetCore.Authorization.Authorize]
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == id);
            var types = _context.SubscribtionTypes.ToList();
            var serviceList = new List<string>();
            if (customer != null && customer.MembershipTypeId == 1)
            {
                serviceList = new List<string>
                {
                    "Data Collection",
                    "Radio services",
                    "Television services",
                    "Internet services",
                    "Telephone services"
                };
            }
            if (customer != null && customer.MembershipTypeId == 2)
            {
                serviceList = new List<string>
                {
                    "Star Maps",
                    "Information about Black Holes",
                    "Pictures of the Planets in the Solar System",
                    "Maps of different planetary surfaces"
                };
            }
            if (customer != null && customer.MembershipTypeId == 3)
            {
                serviceList = new List<string>
                {
                    "Satellite Images",
                    "Data Acquisition",
                    "Meteorology",
                    "Earth Maps"
                };
            }
            if (customer != null && customer.MembershipTypeId == 4)
            {
                serviceList = new List<string>
                {
                    "Renewable Energy"
                };
            }
            var viewModel = new CustomerDetailsViewModel
            {
                Customer = customer,
                SubscribtionTypes = types,
                ServiceList = serviceList
            };
            

            if (customer != null)
            {

                return View(viewModel);
            }
            else
            {
                return NotFound();
            }
        }

    }
}
