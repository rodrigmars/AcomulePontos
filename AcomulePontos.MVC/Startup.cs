using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AcomulePontos.MVC.Startup))]
namespace AcomulePontos.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
