using System.Web;
using System.Web.Optimization;

namespace AdformAcademyTask
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/Styles/Site.min.css"));

            bundles.Add(new ScriptBundle("~/Content/js").Include(
                        "~/Content/libs/jquery/dist/jquery.min.js",
                        "~/Scripts/Scripts.js"));
        }
    }
}
