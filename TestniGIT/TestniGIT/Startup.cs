using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestniGIT.Startup))]
namespace TestniGIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
