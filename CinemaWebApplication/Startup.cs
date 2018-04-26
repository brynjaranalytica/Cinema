using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CinemaWebApplication.Startup))]
namespace CinemaWebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
