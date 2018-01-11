using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BobWebsite.Startup))]
namespace BobWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
