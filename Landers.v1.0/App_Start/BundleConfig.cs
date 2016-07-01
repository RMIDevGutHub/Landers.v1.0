using System.Web;
using System.Web.Optimization;

namespace Landers.v1
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;   //enable CDN support

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/_1col_vert_heroform_noheader.css",
                      "~/Content/_1col_vert_heroform.css"));
            
            bundles.Add(new StyleBundle("~/Content/cdn","https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css").Include("~/Content/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/Scripts/jQueryValidate",
                      "http://ajax.aspnetcdn.com/ajax/jquery.validate/1.5.5/jquery.validate.min.js").Include("~/Content/site.js"));

            bundles.Add(new ScriptBundle("~/Scripts/jQueryValidateUnobtrusive",
                      "http://ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js").Include("~/Content/site.js"));

            bundles.Add(new ScriptBundle("~/Scripts/jQuery",
                "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.2.2.min.js").Include("~/Scripts/jquery-{version}.js",
                "~/Content/site.js"));

            bundles.Add(new ScriptBundle("~/Scripts/jQueryUi",
                "http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.5/jquery-ui.min.js").Include("~/Content/site.js"));

            bundles.Add(new ScriptBundle("~/Scripts/bootStrap",
                "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js").Include("~/Content/site.js"));


            //-- Added so bundlkes will work in debug mode ----
            BundleTable.EnableOptimizations = true;
        }
    }
}
