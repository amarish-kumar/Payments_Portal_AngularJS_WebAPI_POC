using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace WebAPIService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public log4net.ILog logger = log4net.LogManager.GetLogger(typeof(WebApiApplication));
        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo(Server.MapPath("~/log4net.config")));
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
