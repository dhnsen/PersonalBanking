using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalBanking.Startup))]
namespace PersonalBanking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
