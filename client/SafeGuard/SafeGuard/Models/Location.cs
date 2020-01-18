using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SafeGuard.Models
{
    public class Location
    {
        public Location()
        {
            
        }

        [Display(Name = "UserName")]
        public string UserName { get; set; }
        [Display(Name = "Latitude")]
        public string Latitude { get; set; }
        [Display(Name = "Longitude")]
        public string Longitude { get; set; }
        [Display(Name = "Send Interval")]
        public string UserChoice { get; set; }

        
    }
    }
