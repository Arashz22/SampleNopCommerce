using System.Web.Routing;
using Nop.Core.Plugins;
using Nop.Services.Common;

namespace Nop.Plugin.Misc.HelloWorld
{
    public class HelloWorldPlugin : BasePlugin, IMiscPlugin
    {
        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "HelloWorld";
            routeValues = new RouteValueDictionary()
            {
                { "Namespaces", "Nop.Plugin.Misc.HelloWorld.Controllers" },
                { "area", null }
            };

        }
    }
}
