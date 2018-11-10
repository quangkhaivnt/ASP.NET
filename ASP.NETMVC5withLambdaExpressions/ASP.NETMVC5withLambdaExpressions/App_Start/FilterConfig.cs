using System.Web;
using System.Web.Mvc;

namespace ASP.NETMVC5withLambdaExpressions
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
