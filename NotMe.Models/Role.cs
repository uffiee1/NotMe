using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace NotMe.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }

        public const string Administrator = "Admin";
        public const string Gebruiker = "User";
    }
}
