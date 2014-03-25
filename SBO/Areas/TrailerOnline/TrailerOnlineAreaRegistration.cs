using System.Web.Mvc;

namespace SBO.Areas.TrailerOnline
{
    public class TrailerOnlineAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "TrailerOnline";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "TrailerOnline_default",
                "TrailerOnline/{customer}/{controller}/{action}/{id}",
                new { area = "TrailerOnline", customer = "Demo", controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "SBO.Areas.TrailerOnline.Controllers" }
            );
        }
    }
}
