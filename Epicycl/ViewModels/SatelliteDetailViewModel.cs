using Epicycl.Models;

namespace Epicycl.ViewModels
{
    public class SatelliteDetailViewModel
    {
        public IEnumerable<SatelliteTypes> SatelliteTypes { get; set; }
        public Satellite Satellite { get; set; }
    }
}
