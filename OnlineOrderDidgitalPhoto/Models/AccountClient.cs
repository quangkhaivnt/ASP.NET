using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccountClient
    {
        OnlineOrderPhotoDbContext db = null;
        public AccountClient()
        {
            db = new OnlineOrderPhotoDbContext();
        }

        public Customer GetById(string userName)
        {
            return db.Customers.SingleOrDefault(x => x.email == userName);
        }

        public bool Login(string userName, string passWord)
        {
            var result = db.Customers.Count(x => x.email == userName && x.password == passWord);
            if (result > 0)
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
