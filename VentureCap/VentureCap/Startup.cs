using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VentureCap.Startup))]
namespace VentureCap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
