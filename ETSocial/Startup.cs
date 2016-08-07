using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ETSocial.Startup))]
namespace ETSocial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
