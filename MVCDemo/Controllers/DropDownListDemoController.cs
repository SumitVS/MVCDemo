using MVCDemo.DAL;
using MVCDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    //https://www.c-sharpcorner.com/UploadFile/4d9083/binding-dropdownlist-in-mvc-in-various-ways-in-mvc-with-data/
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
            //model.States = DB.States.ToList();
            //model.Cities = DB.Cities.ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult DynamicDDL(DynamicDDLViewModel model)
        {
            model.Countries = DB.Countries.ToList();
            return View(model);
        }

        public JsonResult FillDDL(string Flag,int Id)
        {
            if (Flag == "Country")
                return Json(DB.Countries.ToList() , JsonRequestBehavior.AllowGet);
            if (Flag == "State")
                return Json( DB.States.Where(x=>x.Country.CountryId==Id).ToList(), JsonRequestBehavior.AllowGet);
            if (Flag == "City")
                return Json(DB.Cities.Where(x=>x.State.StateId==Id).ToList(), JsonRequestBehavior.AllowGet);
            else               
                return Json(null, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DynamicDDLWithDynamicJQueryFunction()
        {
            DynamicDDLViewModel model = new DynamicDDLViewModel();
            model.Countries = DB.Countries.ToList();
            //model.States = DB.States.ToList();
            //model.Cities = DB.Cities.ToList();
            return View(model);
        }

    }
}