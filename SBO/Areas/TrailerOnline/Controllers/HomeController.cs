using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBO.Areas.TrailerOnline.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index(string Customer)
        {
            ViewBag.Customer = Customer;
            return View();
        }

    }
}
