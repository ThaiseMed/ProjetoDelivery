using System.Web;
using System.Web.Optimization;

namespace PecaAgora
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-migrate-1.2.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/landingPage").Include(
                      "~/Scripts/plugin-min.js",
                      "~/Scripts/custom-min.js"));

            bundles.Add(new ScriptBundle("~/bundles/common").Include(
                      "~/Scripts/spin.min.js",
                      "~/Scripts/jquery.autosize.min.js",
                      "~/Scripts/jquery.nanoscroller.min.js",
                      "~/Scripts/AppForm.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/plugin-min.css",
                      "~/Content/custom-min.css",
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/material-design-iconic-font.min.css",
                      "~/Content/materialadmin.css",
                      "~/Content/site.css"));
        }
    }
}
