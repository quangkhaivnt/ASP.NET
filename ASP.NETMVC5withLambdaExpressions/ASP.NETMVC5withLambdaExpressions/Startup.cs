using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.NETMVC5withLambdaExpressions.Startup))]
namespace ASP.NETMVC5withLambdaExpressions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
