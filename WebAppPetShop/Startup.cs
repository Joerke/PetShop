using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppPetShop.Startup))]
namespace WebAppPetShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
