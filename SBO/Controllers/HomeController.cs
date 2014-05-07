using SBO.BLL;
using SBO.BLL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CreateDemoModel model = new CreateDemoModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(CreateDemoModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            try
            {
                // create the demo
                UserWebsiteBO demo = WebsiteBLL.CreateDemo(model);
                return RedirectToAction("Index", "Home", new { area = "TrailerOnline", SiteName = demo.SiteName });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex);
                return View(model);
            }
        }


        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

       
    }
}
