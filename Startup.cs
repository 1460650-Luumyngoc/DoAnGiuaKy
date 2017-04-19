using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1460650_.Startup))]
namespace _1460650_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
