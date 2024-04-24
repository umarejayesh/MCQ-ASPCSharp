
using System.Web.Mvc;
using System.Web.Routing;
using BusinessObjects;


namespace MyMVCApplication
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Exam", action = "Publish", id = "" }  // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
            //ModelBinders.Binders.DefaultBinder = new Microsoft.Web.Mvc.DataAnnotations.DataAnnotationsModelBinder();
            
            StructureMapBootStraper.StrapIt();
        }

        protected void Application_BeginRequest()
        {

        }

        protected void Application_EndRequest()
        {
        }



    }
}