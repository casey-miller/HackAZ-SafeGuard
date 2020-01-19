using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SafeGuard.Models
{
    public class Location
    {
        public Location()
        {
            
        }
        [Key]
        [Column("location_id")]
        public int LocationId { get; set; }
        [Display(Name = "UserName")]
        [Column("username")]
        public string UserName { get; set; }
        [Display(Name = "Latitude")]
        [Column("latitude")]
        public string Latitude { get; set; }
        [Display(Name = "Longitude")]
        [Column("longitude")]
        public string Longitude { get; set; }
        [Display(Name = "Send Interval")]
        [Column("user_choice")]
        public string UserChoice { get; set; }

    }
}