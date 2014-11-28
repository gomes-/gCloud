using Microsoft.WindowsAzure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebRole1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ServerIP = HttpContext.Request.ServerVariables["LOCAL_ADDR"];
            ViewBag.ServerLocation = CloudConfigurationManager.GetSetting("Location");
            ViewBag.CustomerIP = HttpContext.Request.ServerVariables["REMOTE_ADDR"];

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Download()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}
