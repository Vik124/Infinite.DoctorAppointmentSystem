using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Infinite.DoctorAppointmentSystem.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Please enter your name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "please enter your password")]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool IsRemember { get; set; }
    }
}
