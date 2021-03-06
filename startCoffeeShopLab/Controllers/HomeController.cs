﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using startCoffeeShopLab.Models;

namespace startCoffeeShopLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new formViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult SubmitForm(formViewModel model)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.Failure = "Something went wrong";
                return
            }
            else
            {
                ViewBag.Success = "Success";
            }
            return null;
        }
        /*public ActionResult UserRegistration()
        {
            ViewBag.Message = "User Registration";

            return View();
        }
        public ActionResult AddUser(UserInfo newUser)
        {
            if (ModelState.IsValid)
            {
                ViewBag.ConfMessage = "Welcome " + newUser.FirstName;
                return View("Confirm");
            }
            else
            {               
                return View("Error");
            }
        }*/
    }
}