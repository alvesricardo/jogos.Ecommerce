using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(jogos.Ecommerce.Web.Startup))]

namespace jogos.Ecommerce.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            IAppBuilder appBuilder = app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Usuario/Login")
            });
        }
    }
}
