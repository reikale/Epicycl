using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Epicycl.Models
{
    public class Satellite
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime LaunchDate { get; set; }
        public string SpaceAgency { get; set; }
        public DateTime? Terminated { get; set; }
        public string Description { get; set; }
    }
    
    
}
