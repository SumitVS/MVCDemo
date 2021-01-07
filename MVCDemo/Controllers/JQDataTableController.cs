using MVCDemo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class JQDataTableController : Controller
    {
        private readonly MVCDemoDbContext DB;
        public JQDataTableController()
        {
            DB = new MVCDemoDbContext();
        }
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEmployee()
        {
            return Json(DB.Employees.ToList());
        }
    }
}