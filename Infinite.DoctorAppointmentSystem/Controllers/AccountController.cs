using Infinite.DoctorAppointmentSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infinite.DoctorAppointmentSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration _configuration;

        public AccountController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {

            return View(login);
        }

        [HttpPost]
        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("token");
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [Route("Account/signup")]
        public IActionResult SignUp(SignUpViewModel signUp)
        {

            if (ModelState.IsValid)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                return View(signUp);
            }
        }


        [HttpGet]
        public IActionResult AdminHome()
        {
            return View();
        }

        [HttpPost]
        [Route("Account/AdminHome")]
        public IActionResult AdminHome(AdminHomeViewModel adminHome)

        {

            if (ModelState.IsValid)
            {
                return RedirectToAction("Login", "AdminHome");
            }
            else
            {
                return View(adminHome);
            }
        }

        [HttpGet]
        public IActionResult PatientHome()
        {
            return View();
        }

        [HttpPost]
        [Route("Account/PatientHome")]
        public IActionResult PatientHome(PatientHomeViewModel patientHome)

        {

            if (ModelState.IsValid)
            {
                return RedirectToAction("PatientLogin", "PatientHome");
            }
            else
            {
                return View(patientHome);
            }
        }


        [HttpGet]
        public IActionResult PatientLogin()
        {
            return View();
        }

        [HttpPost]
        [Route("Account/PatientLogin")]
        public IActionResult PatientLogin(PatientLogin patientLogin)

        {

            if (ModelState.IsValid)
            {
                return RedirectToAction("PatientLogin", "Account");
            }
            else
            {
                return View(patientLogin);
            }

        }
    }
}
  
