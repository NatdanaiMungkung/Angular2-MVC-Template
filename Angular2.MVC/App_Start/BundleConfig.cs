using System.Web;
using System.Web.Optimization;

namespace Angular2.MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/core").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/dependencies").Include(
                "~/node_modules/core-js/client/shim.min.js",
                "~/node_modules/zone.js/dist/zone.js",
                "~/node_modules/reflect-metadata/Reflect.js",
                "~/node_modules/systemjs/dist/system.src.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/styles.css"));
        }
    }
}
