using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class DataAnnotationsController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var model = new Student();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Student student)
        {
            if (ModelState.IsValid)
            {
                return View("Success");
            }
            else
            {
                return View(student);
            }
            
        }
    }
}