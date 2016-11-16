using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Entity1.Startup))]
namespace Entity1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
