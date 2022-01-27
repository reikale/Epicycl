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
