using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pubApp.Startup))]
namespace pubApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
