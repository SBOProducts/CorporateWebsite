﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBO.Areas.TrailerOnline.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /TrailerOnline/Home/

        public ActionResult Index(string SiteName)
        {
            ViewBag.SiteName = SiteName;
            return View();
        }



    }
}
