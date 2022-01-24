using Epicycl.Models;
using Epicycl.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Epicycl.Controllers
{
    public class SetelliteController : Controller
    {
        // GET: Setellite/Random
        public ActionResult Random()
        {
            var setellite = new Setellite() { Name = "Best Setellite" };
            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith"},
                new Customer { Name = "Mary Williams"}
            };

            var viewModel = new RandomSetelliteViewModel
            {
                Setellite = setellite,
                Customer = customers
            };

            return View(viewModel);
        }
        
    }
}
