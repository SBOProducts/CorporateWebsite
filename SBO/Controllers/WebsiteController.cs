using SBO.BLL;
using SBO.BLL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace SBO.Controllers
{
    public class WebsiteController : Controller
    {

        /// <summary>
        /// Returns a view showing all the websites currently accessible to the user
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public ActionResult MyWebsites()
        {
            IEnumerable<UserWebsiteBO> sites = WebsiteBLL.GetUserWebsites(WebSecurity.CurrentUserId);
            return View(sites);
        }


        [Authorize]
        public ActionResult CreateWebsite()
        {
            UserWebsiteBO model = new UserWebsiteBO() { UserId = WebSecurity.CurrentUserId };
            return View(model);
        }


        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult CreateWebsite(UserWebsiteBO model)
        {
            if(!ModelState.IsValid)
                return View(model);

            // create the new website
            model = WebsiteBLL.CreateWebsite(model);

            // take the user to their new website
            return RedirectToAction("Index", "Home", new { area = "TrailerOnline", SiteName = model.SiteName });
        }


    }
}
