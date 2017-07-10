using System.Web;
using System.Web.Optimization;

namespace GlobalVisionVendor.SPA
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            #region JS's

            #region   JS  DASHBOARD

            bundles.Add(new ScriptBundle("~/Scripts/DASHBOARD").Include(
                                         "~/Scripts/jquery-1.10.2.js",
                                         "~/Scripts/angular.js",
                                         "~/Scripts/ui-grid.js",
                                         "~/Scripts/angular-cookies.js",
                                         "~/Scripts/angular-block-ui.js",
                                         "~/Scripts/crossfilter.v1.js",
                                         "~/Scripts/crossfilter.v1.min.js",
                                         "~/Scripts/d3.js",
                                         "~/Scripts/d3.min.js",
                                         "~/Scripts/d3.v2.js",
                                         "~/Scripts/d3.v2.min.js",
                                         "~/Scripts/d3.v3.js",
                                         "~/Scripts/d3.v3.min.js"
                                         ));

            #endregion

            #endregion


            #region   JS  INDEX

            bundles.Add(new ScriptBundle("~/Scripts/index").Include(
                                         "~/Scripts/jquery-1.10.2.js",
                                         "~/Scripts/angular.js",
                                         "~/Scripts/ui-grid.js",
                                         "~/Scripts/angular-cookies.js",
                                         "~/Scripts/angular-block-ui.js",
                                         "~/Scripts/line_reader.js"
                                         ));


            #endregion

            #region CSS  INDEX

            bundles.Add(new StyleBundle("~/Content/index").Include(
                                        "~/Content/bootstrap.css",
                                        "~/Content/bootstrap.min.css",
                                        "~/Content/site.css",
                                        "~/Content/styleIndex.css",
                                        "~/Content/ui-grid.css",
                                        "~/Content/angular-block-ui.css"));


            #endregion

            BundleTable.EnableOptimizations = false;

        }
    }
}
