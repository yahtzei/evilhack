using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EvilHack.Startup))]
namespace EvilHack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
