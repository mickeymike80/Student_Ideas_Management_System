using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIMSCoursework.Startup))]
namespace SIMSCoursework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
