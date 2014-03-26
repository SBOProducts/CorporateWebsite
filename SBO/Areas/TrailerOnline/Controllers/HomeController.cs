using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBO.Areas.TrailerOnline.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.CustomerId = SBO.Core.SBOUser.CustomerId;
            return View();
        }

    }
}
