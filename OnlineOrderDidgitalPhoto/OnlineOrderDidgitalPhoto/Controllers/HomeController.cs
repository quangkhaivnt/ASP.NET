using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineOrderDidgitalPhoto.Controllers
{
    public class HomeController : BaseClientController
    {
        // GET: Home
        public ActionResult Index()
        {
            var productClient = new ProductClient();
            ViewBag.NewProduct = productClient.ListNewProduct(4);
            ViewBag.Saleproduct = productClient.ListSaleProduct(4);

            return View();
            
        }


    }
}