using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityFrameworkDatabaseSecond.Startup))]
namespace EntityFrameworkDatabaseSecond
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
