using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapGridSystem.Startup))]
namespace BootstrapGridSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
