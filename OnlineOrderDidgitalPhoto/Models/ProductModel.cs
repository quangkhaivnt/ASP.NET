using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductModel
    {
        private OnlineOrderPhotoDbContext context = null;
        public ProductModel()
        {
            context = new OnlineOrderPhotoDbContext();
        }

        public List<Product> ListAll()
        {
            var list = context.Database.SqlQuery<Product>("Sp_Product_ListAll").ToList();
            return list;
        }

    }
}
