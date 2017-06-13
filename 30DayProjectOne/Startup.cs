using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_30DayProjectOne.Startup))]
namespace _30DayProjectOne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
