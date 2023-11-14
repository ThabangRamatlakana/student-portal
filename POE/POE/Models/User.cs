using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POE.Models
{
    public class User
    {
       
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter your username")]
        [Display (Name = "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
