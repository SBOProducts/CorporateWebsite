using System.Web;
using System.Web.Optimization;

namespace SBO
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {



            #region Foundation Bundles
            bundles.Add(Foundation.Styles());
            bundles.Add(Foundation.Scripts());
            #endregion


            #region SBO Bundles
            bundles.Add(SBOBundles.Styles());
            bundles.Add(SBOBundles.Scripts());
            #endregion
        }
    }
}