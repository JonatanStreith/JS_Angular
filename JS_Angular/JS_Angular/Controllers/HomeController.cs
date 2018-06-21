using JS_Angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JS_Angular.Controllers
{
    public class HomeController : Controller
    {

        PersonDataContext context = new PersonDataContext();

        // GET: Home
        public ActionResult Index()
        {
            //StaticData.PopulateDatabase();

            return View();
        }


        public ActionResult Database()
        {       

            return View();
        }

        //[HttpPost]
        public JsonResult RetrieveData(string Id)
        {


            Person pers = context.People.First(x => x.Id.ToString() == Id);

            return Json(pers);
        }

    }
}