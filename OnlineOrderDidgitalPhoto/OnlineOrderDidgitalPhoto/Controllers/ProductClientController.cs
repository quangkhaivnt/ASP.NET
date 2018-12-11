using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineOrderDidgitalPhoto.Controllers
{
    public class ProductClientController : Controller
    {
        // GET: ProductClient
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult ProductCategory()
        {
            var model = new ProductCategory().ListAll();
            return PartialView(model);
        }

        public ActionResult Detail(int id)
        {
            var product = new ProductClient().ViewDetail(id);
            ViewBag.Category = new ProductCategory().ViewDetail(product.categoryId.Value);
            ViewBag.RelatedProducts = new ProductClient().ListRelatedProducts(id);
            return View(product);
        }
    }
}