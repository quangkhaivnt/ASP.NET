using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductClient
    {
        OnlineOrderPhotoDbContext db = null;
        public ProductClient()
        {
            db = new OnlineOrderPhotoDbContext();
        }

        public List<Product> ListNewProduct(int top)
        {
            return db.Products.OrderByDescending(x => x.createdAt).Take(top).ToList();
        }

        public List<Product> ListSaleProduct(int top)
        {
            return db.Products.OrderByDescending(x => x.sale == 1).Take(top).ToList();
        }

        public List<Product> ListRelatedProducts(int productID)
        {
            var product = db.Products.Find(productID);
            return db.Products.Where(x => x.productid != productID && x.categoryId == product.categoryId).ToList();
        }

        public Product ViewDetail(int id)
        {
            return db.Products.Find(id);
        }
    }
}
