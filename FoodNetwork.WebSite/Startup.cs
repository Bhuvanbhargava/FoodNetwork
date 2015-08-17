using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodNetwork.WebSite.Startup))]
namespace FoodNetwork.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
