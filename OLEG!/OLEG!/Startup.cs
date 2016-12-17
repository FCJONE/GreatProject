using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OLEG_.Startup))]
namespace OLEG_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
