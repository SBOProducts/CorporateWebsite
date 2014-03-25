using System.Web.Mvc;

namespace SBO.Areas.ContractorOnline
{
    public class ContractorOnlineAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ContractorOnline";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ContractorOnline_default",
                "ContractorOnline/{customer}/{controller}/{action}/{id}",
                new { area = "ContractorOnline", customer = "Demo", controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "SBO.Areas.ContractorOnline.Controllers" }
            );
        }
    }
}
