using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KapyTest1.Startup))]
namespace KapyTest1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
