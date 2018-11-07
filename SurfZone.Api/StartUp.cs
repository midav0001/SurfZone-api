using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using SurfZone.Api;
using SurfZone.DataAccess;

[assembly: OwinStartup(typeof(StartUp))]
namespace SurfZone.Api
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            ////app.CreatePerOwinContext<SurfZoneIdentityDbContext>(SurfZoneIdentityDbContext.Create);
            //app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);

            //app.UseCookieAuthentication(new CookieAuthenticationOptions
            //{
            //    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            //    LoginPath = new PathString("/Account/Login"),
            //});
        }
    }
}