using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjLICTWeb.Startup))]
namespace ProjLICTWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
