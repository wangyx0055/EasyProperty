using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyProperty.WebApp.Startup))]
namespace EasyProperty.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
