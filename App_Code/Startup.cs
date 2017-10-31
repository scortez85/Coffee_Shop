using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coffee_Shop_Website.Startup))]
namespace Coffee_Shop_Website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
