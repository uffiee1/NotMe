using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NotMe.Models
{
    public class ToDo
    {
        //Tasks
        public int ToDoId { get; set; }

        public string Event { get; set; }

        public bool Favorite { get; set; }

        //Location
        public int Location { get; set; }

        //User Info
        [ForeignKey("UserId")]
        public User User { get; set; }

        public string UserId { get; set; }

        //Label
        public int Label { get; set; }

        //Status
        public int Status { get; set; }

        //Date
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
