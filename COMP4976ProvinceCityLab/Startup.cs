using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMP4976ProvinceCityLab.Startup))]
namespace COMP4976ProvinceCityLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
