using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication2GitHub.Startup))]
namespace WebApplication2GitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
