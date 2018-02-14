using System.Web;
using System.Web.Hosting;
using System.Web.Optimization;

namespace WebApp
{
  public class BundleConfig
  {
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                  "~/Scripts/angular.min.js",
                  "~/Scripts/angular-sanitize.min.js",
                  "~/Scripts/angular/app.js"));

      bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                  "~/Scripts/jquery-{version}.js"));

      bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                  "~/Scripts/jquery.validate*"));

      bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                  "~/Scripts/modernizr-*"));

      bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

      bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/bootstrap-grid.min.css",
                "~/Content/bootstrap-reboot.min",
                "~/Content/site.css",
                "~/Content/app.css"));

      //BundleTable.EnableOptimizations = true;
      //VirtualPathProvider.OpenFile("~/Scripts/angular/app.js");
    }
  }
}
