using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodNow.Startup))]
namespace FoodNow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
