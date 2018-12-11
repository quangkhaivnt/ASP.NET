using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductCategory
    {
        OnlineOrderPhotoDbContext db = null;
        public ProductCategory()
        {
            db = new OnlineOrderPhotoDbContext();
        }

        public List<Category> ListAll()
        {
            return db.Categories.Where(x=>x.status == 1).OrderBy(x =>x.nameCategory).ToList();
        }

        public Category ViewDetail(int id)
        {
            return db.Categories.Find(id);
        }
    }
}
