using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectZip.Startup))]
namespace ProjectZip
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
