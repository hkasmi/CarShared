using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarShared.WebUI.Startup))]
namespace CarShared.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
