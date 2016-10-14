using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BecomeAPro.Startup))]
namespace BecomeAPro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
