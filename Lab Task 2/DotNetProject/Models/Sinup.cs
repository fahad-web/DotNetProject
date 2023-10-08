using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DotNetProject.Models
{
    public class Sinup
    {
        [Required(ErrorMessage = "Provide FUll Name")]
        [RegularExpression(@"[A-Za-z\s\.\-]{4,50}", ErrorMessage = "Invalid input. Please enter a valid name.")]

        public string Name { get; set; }
        [Required]
        [RegularExpression(@"\d{2}-\d{5}-\d{1}", ErrorMessage = "Must Be match XX-XXXXX-X this fromet")]
        public string Id { get; set; }
        [Required]
        [RegularExpression(@"(?=.{8,})[A-Za-z]{4}[\w!#$%^&*]+\d$", ErrorMessage = "Use strong password")]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Date { get; set; }
    }
}