﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Epicycl.Models
{
    public class Satellite
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }
        [BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
        public DateTime LaunchDate { get; set; }
        public string Operator { get; set; }
        [BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? Terminated { get; set; }
        public string Description { get; set; }
        public string ImageLink { get; set; }
    }
    
    
}
