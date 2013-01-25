using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DarciWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JsonResult Authenticate(string user, string pass)
        {
            if (user == "darci76844" && pass == "lillian00")
                return Json(new { success = "1", token = "omgwtfbbqsauceopotamus" });
            else
                return Json(new { success = "0", token = "incorrect" });
        }
    }
}
