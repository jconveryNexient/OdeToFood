using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Filters;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        [Log]          
        public ActionResult Search(string name = "french")
        {
            //throw new Exception("Something terrible has happened");
            var message = Server.HtmlEncode(name);            
            return Json(new { Message = message, Name = "Matt" }, JsonRequestBehavior.AllowGet);
        }

        //// GET: Cuisine 
        //[HttpGet]       
        //public ActionResult Search()
        //{
        //    //return Content(message);
        //    //return RedirectToAction("Index", "Home", new { name = name });
        //    //return RedirectToRoute("Default", new {controller = "Home", action = "About"});
        //    //return File(Server.MapPath("~/Content/site.css"), "text/css");
        //    return Content("Search");
        //}
    }
}