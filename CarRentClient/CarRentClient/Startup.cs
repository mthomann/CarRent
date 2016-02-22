using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarRentClient.Startup))]
namespace CarRentClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
