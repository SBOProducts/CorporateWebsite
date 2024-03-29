using System.Web.Optimization;

namespace SBO
{
    public static class Foundation
    {
        public static Bundle Styles()
        {
            return new StyleBundle("~/Content/foundation/css").Include(
                       "~/Content/foundation/foundation.css",
                       "~/Content/foundation/foundation.mvc.css");
        }

        public static Bundle Scripts()
        {
            return new ScriptBundle("~/bundles/foundation").Include(
                      "~/Scripts/foundation/modernizr.js",
                      "~/Scripts/foundation/fastclick.js",
                      "~/Scripts/jquery.cookie.js",
                      "~/Scripts/foundation/foundation.js",
                      "~/Scripts/foundation/foundation.*");
        }
    }
}