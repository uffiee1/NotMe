using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NotMe.Models
{
    public class ToDo
    {
        //Tasks
        public int ToDoID { get; set; }

        public string Event { get; set; }

        public bool Favorite { get; set; }

        //Location
        public double AccelX { get; set; }

        public double AccelY { get; set; }

        public double AccelZ { get; set; }

        //User Info
        public User User { get; set; }

        public string UserId { get; set; }

        //Label
        public string Label { get; set; }

        //Status
        public string Status { get; set; }

        //Date
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
