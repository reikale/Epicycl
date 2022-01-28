using Epicycl.Models;
using Epicycl.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Epicycl.Controllers
{
    public class SatelliteController : Controller
    {
        private DataContext _context;
        public SatelliteController(DataContext context)
        {
            _context = context;
        }
        // GET: Setellite/Random
        public ActionResult Details(int id)
        {
            var satellite = _context.Satellites.SingleOrDefault(x => x.Id == id);

            if (satellite != null)
            {

                return View(satellite);
            }
            else
            {
                return NotFound();
            }
        }
        public ActionResult New(Satellite satellite)
        {
            var viewModel = new SatelliteFormViewModel
            {
                Satellite = new Satellite(),
                SatelliteTypes = new List<string>
                {
                    "Astronomical satellites",
                    "Earth observation satellites",
                    "Communication satellites",
                    "Navigational satellites",
                    "Space stations"
                }
            };   
            return View(viewModel);
        }
        public ActionResult Save(Satellite satellite)
        {
            if (satellite.Id == 0)
            {
                _context.Satellites.Add(satellite);
            }
            else
            {
                var satellietsInDb = _context.Satellites.Single(x => x.Id == satellite.Id);
                satellietsInDb.Name = satellite.Name;
                satellietsInDb.Operator = satellite.Operator;
                satellietsInDb.LaunchDate = satellite.LaunchDate;
                satellietsInDb.Terminated = satellite.Terminated;
                satellietsInDb.Type = satellite.Type;
                satellietsInDb.Description = satellite.Description;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Satellite");
        }
        public ActionResult Edit(int id)
        {
            var satellite = _context.Satellites.SingleOrDefault(x => x.Id == id);
            if (satellite == null)
            {
                return RedirectToAction("Index", "Home");
            }


            var viewModel = new SatelliteFormViewModel
            {
                Satellite = satellite,
                SatelliteTypes = new List<string>
                {
                    "Astronomical satellites",
                    "Earth observation satellites",
                    "Communication satellites",
                    "Navigational satellites",
                    "Space stations"
                }

            };
            return View("New", viewModel); // sitas nukelia tiesiai i View.New kad butu sukurtas varototojas jei tokio nerado

        }
        public ActionResult Index()
        {
            
            var satellites = _context.Satellites;

            if(satellites != null)
            {
                
                return View(satellites);
            }
            else
            {
                return NotFound();
            }

            
        }
       
    }
}
