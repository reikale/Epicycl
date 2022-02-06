using Epicycl.Models;
using Epicycl.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
        

        [Authorize]
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


        [Authorize(Roles = "SatelliteOwner")]
        public ActionResult New(Satellite satellite)
        {
            var viewModel = new SatelliteFormViewModel
            {
                Satellite = satellite,
                SatelliteTypes = _context.SatelliteTypes.Select(x => x.Name).ToList()
            };   
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Satellite satellite)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new SatelliteFormViewModel
                {
                    Satellite = satellite,
                    SatelliteTypes = _context.SatelliteTypes.Select(x => x.Name).ToList()
                };
                return View("New", viewModel);
            }
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


        [Authorize(Roles ="AdminUser")]
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
                SatelliteTypes = _context.SatelliteTypes.Select(x => x.Name).ToList()
            

            };
            return View("New", viewModel); // sitas nukelia tiesiai i View.New kad butu sukurtas varototojas jei tokio nerado

        }

        [Authorize(Roles = "AdminUser")]
        public ActionResult Delete(int id)
        {
            var satellite = _context.Satellites.SingleOrDefault(x => x.Id == id);
            if (satellite == null)
            {
                return NotFound();
            }
            _context.Satellites.Remove(satellite);
            _context.SaveChanges();
            return RedirectToAction("Index", "Satellite");
        }


        [Authorize]
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
