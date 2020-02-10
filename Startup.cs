using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolPortal.Startup))]
namespace SchoolPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
