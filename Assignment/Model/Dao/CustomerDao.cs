using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class CustomerDao
    {
        OnlineShopDbContext db = null;
        public CustomerDao()
        {
            db = new OnlineShopDbContext();
        }
        public int Insert(Customer entity)
        {
            db.Customers.Add(entity);
            db.SaveChanges();
            return entity.id;
        }

        public Customer GetById(string email)
        {
            return db.Customers.SingleOrDefault(x => x.email == email);
        }

        public bool Login(string userName, string passWord)
        {
            var result = db.Customers.Count(x => x.email == userName && x.password == passWord);
            if(result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
