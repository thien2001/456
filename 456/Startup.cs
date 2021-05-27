using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_456.Startup))]
namespace _456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
