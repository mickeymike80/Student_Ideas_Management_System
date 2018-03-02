using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIMSCoursework.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Index()
        {
            //Session.Clear();
            return View();
        }

        private user findUser(string username , string password)
        {
            List<user> users = (new SIMData()).users.ToList();
            foreach (user user in users)
            {
                if (user.user_Email == username && user.user_Password == password)
                {
                    return user;
                }
            }
            return null;
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Index(user user)
        {
            user loginAttempt = findUser(user.user_Email, user.user_Password);
                if(loginAttempt == null)
                {
                    ViewBag.message = "Incorrect user credential";
                    return View();
                }
                else
                {
                    //authetication passed
                    Session["loggedUser"] = loginAttempt;
                    return RedirectToAction("index", "Home");
                }

        }
    }
}