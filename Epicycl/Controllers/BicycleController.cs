using Epicycl.Models;
using Microsoft.AspNetCore.Mvc;

namespace Epicycl.Controllers
{
    public class BicycleController : Controller
    {
        // GET: Bicycle/Random
        public ActionResult Random()
        {
            var bike = new Bicycle() { Name = "Ingos dviratis" };

            return View(bike);
            // return Content("Labas as krabas");
            // return NotFound();
        }
    }
}
