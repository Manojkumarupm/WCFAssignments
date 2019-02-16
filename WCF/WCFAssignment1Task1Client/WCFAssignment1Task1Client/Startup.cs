using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WCFAssignment1Task1Client.Startup))]
namespace WCFAssignment1Task1Client
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
