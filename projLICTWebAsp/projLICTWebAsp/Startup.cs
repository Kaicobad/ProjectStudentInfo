using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projLICTWebAsp.Startup))]
namespace projLICTWebAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
