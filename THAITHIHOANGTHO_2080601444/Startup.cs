using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(THAITHIHOANGTHO_2080601444.Startup))]
namespace THAITHIHOANGTHO_2080601444
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
