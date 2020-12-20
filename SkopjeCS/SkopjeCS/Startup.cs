using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkopjeCS.Startup))]
namespace SkopjeCS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
