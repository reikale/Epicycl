using Epicycl.Models;
using Epicycl.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Epicycl.Controllers
{
    public class SatelliteController : Controller
    {
        // GET: Setellite/Random
        public ActionResult Random()
        {
            var satellite = new Satellite() { Name = "Random action" };
            var customers = new List<Customer>
            {
                new Customer { Name = "vienas"},
                new Customer { Name = "du"}
            };

            var viewModel = new RandomSatelliteViewModel
            {
                
                Customer = customers
            };

            return View(viewModel);
        }
       
        public ActionResult Index()
        {
            
            var satellites = GetSatellites();

            if(satellites != null)
            {
                
                return View(satellites);
            }
            else
            {
                return NotFound();
            }

            
        }
        private List<Satellite> GetSatellites()
        {
            return new List<Satellite>
            {
                 new Satellite { Id=0, Name = "Second Small Astronomy Satellite (SAS 2)"},
                 new Satellite{ Id=1, Name = "3rd High Energy Astronomy Observatory (HEAO 3)"}
            };
        }
    }
}
