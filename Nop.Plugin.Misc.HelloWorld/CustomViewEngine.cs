using System.Web.Mvc;

namespace Nop.Plugin.Misc.HelloWorld
{
    public class CustomViewEngine : RazorViewEngine //ThemeableRazorViewEngine  //RazorViewEngine
    {
        public CustomViewEngine()
        {
            PartialViewLocationFormats = new[] { "~/Plugins/Misc.HelloWorld/Views/{0}.cshtml" };
            ViewLocationFormats = new[] { "~/Plugins/Misc.HelloWorld/Views/{0}.cshtml" };

            //AreaPartialViewLocationFormats = new[] { "~/Plugins/Misc.HelloWorld/Views/{0}.cshtml" };
            //AreaViewLocationFormats = new[] { "~/Plugins/Misc.HelloWorld/Views/{0}.cshtml" };
        }
    }
}
