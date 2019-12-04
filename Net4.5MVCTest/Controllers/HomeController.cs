using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Net4._5MVCTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public void Exception1()
        {
            throw new System.InvalidOperationException("Logfile cannot be read-only");
        }

        public void Exception2()
        {
            throw new System.ArgumentException("Parameter cannot be null", "original");
        }

        public void Exception3()
        {
            throw new Exception("division by zero");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}