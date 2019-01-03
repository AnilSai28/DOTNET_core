using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using first_mvc_core.Models;
using Microsoft.AspNetCore.Http;
using first_mvc_core.services;

namespace first_mvc_core.Controllers
{
    public class HomeController : Controller
    {
        iservice dep;
        public HomeController(iservice dep)
        {
            this.dep = dep;
        }

        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult login(loginmodel model)
        {
            if(ModelState.IsValid)
            {
                if(model.LoginID=="user1" && model.Password=="pass@123")
                {
                    //HttpContext.Session.SetString("loginid", model.LoginID);
                    return RedirectToAction("index", "Home");
                }
                else
                {
                    ViewBag.msg = "invalid id or password";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        public IActionResult index()
        {
            string guid = dep.GetGuidID();
            int sum = dep.getsum(10, 20);
            ViewBag.msg1 = "result : " + sum;
            ViewBag.msg2 = guid;
            return View();
        }
    }
}