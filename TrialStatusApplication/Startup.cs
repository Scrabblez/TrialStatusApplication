using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrialStatusApplication.Startup))]
namespace TrialStatusApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
