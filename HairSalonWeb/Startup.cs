using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HairSalonWeb.Startup))]
namespace HairSalonWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
