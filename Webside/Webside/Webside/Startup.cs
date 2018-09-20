using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webside.Startup))]
namespace Webside
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
