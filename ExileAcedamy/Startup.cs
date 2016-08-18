using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExileAcedamy.Startup))]
namespace ExileAcedamy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
