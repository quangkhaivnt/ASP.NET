using OnlineOrderDidgitalPhoto.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineOrderDidgitalPhoto.Controllers
{
    public class BaseClientController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (UserLogin)Session[CommonConstants.USER_SESSION];
            if (session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
                    System.Web.Routing.RouteValueDictionary(new { controller = "CustomerClient", action = "Login"}));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}