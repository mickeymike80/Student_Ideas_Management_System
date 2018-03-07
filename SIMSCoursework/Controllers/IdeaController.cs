using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIMSCoursework.Controllers
{
    public class IdeaController : Controller
    {
        private SIMData simdata = new SIMData();
        // GET: Idea
        public ActionResult Index()
        {
            List<idea> ideas = simdata.ideas.ToList();
            return View(ideas);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(idea idea)
        {
            if (ModelState.IsValid)
            {
                simdata.ideas.Add(idea);
                simdata.SaveChanges();
                return View("Index");
            }
            else
            {
                ViewBag.error_message = "woops, error occured";
                return View();
            }
        }
 
    }
}