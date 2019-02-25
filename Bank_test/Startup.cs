using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bank_test.Startup))]
namespace Bank_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
