using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotMe.Models
{
    public class Label
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Label")]
        public string Type { get; set; }
    }
}
