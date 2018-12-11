using Models;
using OnlineOrderDidgitalPhoto.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineOrderDidgitalPhoto.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        private OnlineOrderPhotoDbContext context = new OnlineOrderPhotoDbContext();
        
        // GET: Admin/User
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var cus = new AccountModel();
            var model = cus.ListAllPaging(page, pageSize);
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(Customer customer)
        {

            if (ModelState.IsValid)
            {
                var cus = new AccountModel();
                var encry = Encryptor.MD5Hash(customer.password);
                customer.password = encry;
                int id = cus.Insert(customer);
                if (id > 0)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới user không thành công");
                }
            }
            return View("Index");

        }
    }
}