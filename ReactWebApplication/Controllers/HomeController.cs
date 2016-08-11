using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ReactWebApplication.Controllers
{
    public class HomeController : Controller
    {
        ActionResult Index()
        {
            return View();
        }
    }
}