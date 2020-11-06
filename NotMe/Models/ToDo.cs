﻿using System;
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
        public int ToDoID { get; set; }

        [Required]
        public string Event { get; set; }

        public string Location { get; set; }

        public string Status { get; set; }

        //public IEnumerable<SelectListItem> Status { get; set; }

        public IEnumerable<SelectListItem> StatusItems { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public string Label { get; set; }

        //[Required]
        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }
    }
}
