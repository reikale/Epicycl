﻿using Epicycl.Models;

namespace Epicycl.ViewModels
{
    public class SatellitesSatellitesViewModel
    {
        public IEnumerable<SatelliteTypes> SatelliteTypes { get; set; }
        public IEnumerable<Satellite> Satellites { get; set; }
    }
}
