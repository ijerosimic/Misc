using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVjezbe2.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Unesite ime")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Unesite prezime")]
        public string Prezime { get; set; }
        [Required(ErrorMessage = "Unesite email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Unesite status")]
        public bool Status { get; set; }
    }
}
