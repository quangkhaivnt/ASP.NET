using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CategoryModel
    {
        private OnlineOrderPhotoDbContext context = null;
        public CategoryModel()
        {
            context = new OnlineOrderPhotoDbContext();
        }

        public List<Category> ListAll()
        {
            var list = context.Database.SqlQuery<Category>("Sp_Category_ListAll").ToList();
            return list;
        }

        public int Create(int id,string name, string description, string image, int? typeId)
        {
            object[] parameters =
            {
                new SqlParameter("@Id", id),
                new SqlParameter("@NameCategory",name),
                new SqlParameter("@Description", description),
                new SqlParameter("@Image", image),
                new SqlParameter("@TypeId", typeId),
            };
            int res = context.Database.ExecuteSqlCommand("Sp_Category_Insert @Id,@NameCategory,@Description,@Image,@TypeId", parameters);
            return res;
        }
    }
}
