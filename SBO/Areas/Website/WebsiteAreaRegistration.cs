using System.Web.Mvc;

namespace SBO.Areas.Website
{
    public class WebsiteAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Website";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Website_default",
                "Website/{customer}/{controller}/{action}/{id}",
                new {area="Website", customer="Demo", controller="Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "SBO.Areas.Website.Controllers" }
            );

            context.MapRoute(
                "Website_system",
                "Website/System/{controller}/{action}/{id}",
                new { area = "Website", controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "SBO.Areas.Website.Controllers" }
            );
        }
    }
}
