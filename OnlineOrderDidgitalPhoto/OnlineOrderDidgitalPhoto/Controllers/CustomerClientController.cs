using Models;
using OnlineOrderDidgitalPhoto.Areas.Admin.Code;
using OnlineOrderDidgitalPhoto.Common;
using OnlineOrderDidgitalPhoto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineOrderDidgitalPhoto.Controllers
{
    public class CustomerClientController : Controller
    {
        // GET: CustomerClient
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult AccountClient()
        {
            var model = new AccountClient();
            return PartialView(model);
        }

        public ActionResult Login(LoginClientModel model)
        {
            if (ModelState.IsValid)
            {
                var account = new AccountClient();
                var result = account.Login(model.Email, model.Password);
                if (result)
                {
                    var user = account.GetById(model.Email);
                    var userSession = new UserLogin();
                    userSession.UserName = user.email;
                    userSession.Id = user.id;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không thành công");
                }
            }
            return View("Index");
        }

        
    }
}