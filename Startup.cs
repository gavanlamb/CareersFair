using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CareersFair.Startup))]
namespace CareersFair
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
