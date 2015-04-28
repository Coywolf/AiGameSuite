using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AGS_Site.Startup))]
namespace AGS_Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
