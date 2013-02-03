using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DarciWeb.Models;
using SkyNet;

namespace DarciWeb.Controllers
{
    public class GalleryController : Controller
    {
        //
        // GET: /Gallery/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Manage(string z)
        {
            GalleryModel model = new GalleryModel();
            if (z == "omgwtfbbqsauceopotamus")
            {
                model.loginMessage = "Hello schmex!";
                model.loginSuccess = true;
                return View(model);
            }

            
            

            return RedirectToAction("Index", "Home");
        }

    }
}
