using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_40kCampaign.Startup))]
namespace _40kCampaign
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
