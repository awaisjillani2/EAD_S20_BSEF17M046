using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment3.BAL;
using Assignment3.Entities;
using Assignment_3.Security;
using TokenGeneration;

namespace Assignment_3.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.errorMsg = TempData["errorMsg"];
            return View();
        }

        [HttpPost]
        [ActionName("Login")]
        public ActionResult Login2(String login, String password)
        {
            if (String.IsNullOrEmpty("login") || String.IsNullOrEmpty(password))
            {
                ViewBag.errorMsg = "";
                ViewBag.errorMsg = "Please fill all the fields";
                return View("Login");
            }
            var result = UserBO.ValidateUser(login, password);
            if (result != null)
            {
                TokenGenerator obj = new TokenGenerator();
                var token = obj.GetToken(login, result.name);
                TempData["token"] = token;
                ViewBag.errorMsg = "";
                SessionManager.User = result;
                return Redirect("~/User/Home");
            }
            else
            {
                ViewBag.login = login;
                ViewBag.errorMsg = "";
                ViewBag.errorMsg = "Invalid username/password";
                return View("Login");
            }
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SaveUser(UserDTO dto)
        {
            var result = UserBO.SaveUser(dto);
            var d = new
            {
                res = result
            };
            return Json(d, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Home()
        {
            if(SessionManager.IsValidUser)
            {
                return View();
            }
            else
            {
                ViewBag.errorMsg = "";
                TempData["errorMsg"] = "Unauthorized access";
                return Redirect("~/User/Login");
            }
        }
        
    }
}