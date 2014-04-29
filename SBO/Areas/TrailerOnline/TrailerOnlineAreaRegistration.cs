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
                "TrailerOnline/{SiteName}/{controller}/{action}/{id}",
                new { area = "TrailerOnline", SiteName = "Demo", controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "SBO.Areas.TrailerOnline.Controllers" }
            );

            context.MapRoute(
                "TrailerOnline_system",
                "TrailerOnline/System/{controller}/{action}/{id}",
                new { area = "TrailerOnline", controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "SBO.Areas.TrailerOnline.Controllers" }
            );
        }






    }
}
