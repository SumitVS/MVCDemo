using MVCDemo.DAL;
using MVCDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class DropDownListDemoController : Controller
    {
        private MVCDemoDbContext DB;
        public DropDownListDemoController()
        {
            DB = new MVCDemoDbContext();
        }
        // GET: DropDownListDemo
        public ActionResult HardCodedDDL()
        {
            return View();
        }

        public ActionResult DynamicDDL()
        {

            DynamicDDLViewModel model = new DynamicDDLViewModel();           
            model.Countries = DB.Countries.ToList();
            model.States = DB.States.ToList();
            model.Cities = DB.Cities.ToList();

            return View(model);
        }
    }
}