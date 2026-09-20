using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _25dh110526_luuthanhquan.Controllers
{
    public class HomeController : Controller 
    {
        public ActionResult lab1()
        {
            return View();
        }

        public ActionResult lab2()
        {
            return View();
        }
        public ActionResult lab3()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}