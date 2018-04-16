using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Web.Http.Cors;
using System.Net.Http.Headers;

namespace Tringulo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Configuramos la aplicacion para que pueda acceder desde cualquier navegador con cualquier metodo
            config.MapHttpAttributeRoutes();
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{a}/{b}/{c}",
                defaults: new { a = RouteParameter.Optional, b = RouteParameter.Optional, c = RouteParameter.Optional }
            );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}
