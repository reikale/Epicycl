using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Epicycl.Models
{
    public class Satellite
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }
        [BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Launch Date")]
        public DateTime LaunchDate { get; set; }
        public string Operator { get; set; }
        [BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Termination Date")]
        public DateTime? Terminated { get; set; }
        public string Description { get; set; }
        public string? ImageLink { get; set; }
    }
    
    
}
