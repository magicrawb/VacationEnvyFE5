using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VacationEnvyFE5.Startup))]
namespace VacationEnvyFE5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
