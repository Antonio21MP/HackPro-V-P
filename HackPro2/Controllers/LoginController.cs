using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HackPro2.Models;


namespace HackPro2.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }
        [HttpPost]
        public ActionResult Login(LoginModel log)
        {
            if (ModelState.IsValid)
            {
            }
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View("Register");
        }

    }
}