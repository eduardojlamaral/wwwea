using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wwwea.Startup))]
namespace wwwea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
