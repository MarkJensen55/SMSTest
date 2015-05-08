using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMSTest.Startup))]
namespace SMSTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
