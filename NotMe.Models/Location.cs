using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotMe.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        public double Accuracy { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
