using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hello.CI.Web.Startup))]
namespace Hello.CI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
