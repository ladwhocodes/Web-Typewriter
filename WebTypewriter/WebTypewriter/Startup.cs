using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTypewriter.Startup))]
namespace WebTypewriter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
