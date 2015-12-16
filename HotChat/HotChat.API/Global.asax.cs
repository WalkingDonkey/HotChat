using HotChat.API.App_Start;
using HotChat.Framework.Utility;
using System.Web.Http;

namespace HotChat.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfiguration.ConfigureAutoMapper();
        }
    }
}
