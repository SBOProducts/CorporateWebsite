using SBO.BLL;
using SBO.BLL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBO.Controllers
{
    public class AccountController : Controller
    {

        /// <summary>
        /// provides the form to login to the system 
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            LoginBO model = new LoginBO();
            if (Request.QueryString["ReturnUrl"] != null)
                model.ReturnUrl = Request.QueryString["ReturnUrl"];

            return View(model);
        }


        /// <summary>
        /// validates user's credentials and grants access if login is successful
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(LoginBO model)
        {
            return View(model);
        }


        /// <summary>
        /// shows account info for registered users
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public ActionResult MyAccount()
        {

            return View();
        }


        /// <summary>
        /// provides the form for creating a new account
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }


        /// <summary>
        /// validates user registration and creates a new account
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Register(RegisterBO model)
        {
            if (!ModelState.IsValid)
                return View(model);

            SBOUserBO user = AccountBLL.CreateNewRegistration(model);

            return View(model);

        }



    }
}
