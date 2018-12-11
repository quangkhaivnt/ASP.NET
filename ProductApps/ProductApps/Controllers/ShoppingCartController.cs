using ProductApps.Context;
using ProductApps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductApps.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ProductContext db = new ProductContext();
        public ActionResult XoaSanPham(int id)
        {
            ShoppingCart objCart = (ShoppingCart)Session["Cart"];
            if (objCart != null)
            {
                objCart.RemoveFromCart(id);
                Session["Cart"] = objCart;
            }
            return RedirectToAction("index");
        }
        // thêm vào giỏ hàng 1 sản phẩm có id = id của sản phẩm
        public ActionResult ThemVaoGioHang(int id)
        {
            var P = db.Products.Single(s => s.Id.Equals(id));
            if (P != null)
            {
                ShoppingCart objCart = (ShoppingCart)Session["Cart"];
                if (objCart == null)
                {
                    objCart = new ShoppingCart();
                }
                ShoppingCartItem item = new ShoppingCartItem()
                {
                    ProductName = P.ProductName,
                    ProductID = P.Id,
                    //Price = P.Price,
                    Quanlity = 1,
                    //Total = Convert.ToDouble(P.Price.Trim().Replace(",", string.Empty).Replace(".", string.Empty))
                };
                objCart.AddToCart(item);
                Session["Cart"] = objCart;
                return View(P);
            }
            return View(P);
        }
        // cập nhật giỏ hàng theo loại sản phẩm và số lượng
        public ActionResult UpdateQuantity(string proID, int quantity)
        {
            int id = Convert.ToInt32(proID.Substring(7, proID.Length - 7));
            ShoppingCart objCart = (ShoppingCart)Session["Cart"];
            if (objCart != null)
            {
                objCart.UpdateQuantity(id, quantity);
                Session["Cart"] = objCart;
            }
            return RedirectToAction("index");
        }
        // giỏ hàng mặc định, nếu session = null thì hiện không có hàng trong giỏ, nếu có thì trả lại list các sản phẩm
        public ActionResult Index()
        {
            ViewBag.Title = "Giỏ hàng";
            ShoppingCartModels model = new ShoppingCartModels();
            model.Cart = (ShoppingCart)Session["Cart"];
            return View(model);
        }

    }
}
