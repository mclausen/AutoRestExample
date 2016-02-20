using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using Swashbuckle.Application;

namespace WebApplication2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //config.EnableSwagger(c =>
            //{
            //    c.DescribeAllEnumsAsStrings();


            //    var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //    var commentsFileName = Assembly.GetExecutingAssembly().GetName().Name + ".XML";
            //    var commentsFile = Path.Combine(baseDirectory, commentsFileName);

            //    c.IncludeXmlComments(commentsFile);
            //});


            // Web API routes
            config.MapHttpAttributeRoutes();
            config.EnsureInitialized();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
