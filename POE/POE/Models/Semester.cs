using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POE.Models
{
    public class Semester
    {
        public int SemesterId { get; set; }

        [Required(ErrorMessage = "Please enter semester weeks")]
        [Display(Name = "Weeks")]
        public int Weeks { get; set; }

        [Required(ErrorMessage = "Please select semester start date")]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }
    }
}
