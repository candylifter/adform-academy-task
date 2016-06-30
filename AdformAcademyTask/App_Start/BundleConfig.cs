using System.Web;
using System.Web.Optimization;

namespace AdformAcademyTask
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/libs/jquery/dist/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/foundation").Include(
                        "~/Content/libs/foundation-sites/dist/foundation.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/Site.min.css"));
        }
    }
}
