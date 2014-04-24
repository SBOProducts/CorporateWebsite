using System.Web.Optimization;

namespace SBO
{
    public static class SBOBundles
    {
        public static Bundle Styles()
        {
            return new StyleBundle("~/Content/sbo/css").Include(
                       "~/Content/Site.css"
                       );
        }

        public static Bundle Scripts()
        {
            return new ScriptBundle("~/bundles/sbo").Include(
                      "~/Scripts/sbo/navigation.js"
                      );
        }
    }
}