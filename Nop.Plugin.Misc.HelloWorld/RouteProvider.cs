using System.Web.Mvc;
using System.Web.Routing;
using Nop.Web.Framework.Mvc.Routes;

namespace Nop.Plugin.Misc.HelloWorld
{
    public class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            //ViewEngines.Engines.Insert(0, new CustomViewEngine());

            //string name, string url, object defaults, object constraints, string[] namespaces
            //var route = routes.MapRoute("Plugin.Misc.HelloWorld.Edit",
            //     "Admin/Product/Edit/{id}",
            //     new { controller = "HelloWorld", action = "Edit", area = "Admin" }, //notice 'area="Admin"' is added
            //     new { id = @"\d+" },
            //     new[] { "Nop.Plugin.Misc.HelloWorld.Controllers" }
            //);

            var route = routes.MapRoute("Nop.Plugin.Misc.HelloWorld.List",
                 "Admin/Product/List",
                 new { controller = "HelloWorld", action = "List" }, //notice 'area="Admin"' is added
                 new[] { "Nop.Plugin.Misc.HelloWorld.Controllers" }
            );

            route.DataTokens.Add("area", "admin");
            routes.Remove(route);
            routes.Insert(0, route);

            ViewEngines.Engines.Insert(0, new CustomViewEngine());
        }

        public int Priority
        {
            get
            {
                return 0;
            }
        }
    }
}
