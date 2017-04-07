using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SumNumbers_Web.Startup))]
namespace SumNumbers_Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
