using PagedList;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccountModel
    {
        private OnlineOrderPhotoDbContext context = null;
        public AccountModel()
        {
            context = new OnlineOrderPhotoDbContext();
        }

        public int Insert(Customer cus)
        {
            context.Customers.Add(cus);
            context.SaveChanges();
            return cus.id;
        }

        public IEnumerable<Customer> ListAllPaging(int page, int pageSize)
        {
            return context.Customers.OrderByDescending(x=>x.name).ToPagedList(page,pageSize); 
        }

        public Customer GetById(string userName)
        {
            return context.Customers.SingleOrDefault(x=>x.email == userName);
        }

        public int Login(string userName, string passWord)
        {
            var result = context.Customers.SingleOrDefault(x => x.email == userName);
            if(result == null)
            {
                return 0;
            }
            else
            {
                if(result.statusId == null)
                {
                    return -1;
                }
                else
                {
                    if (result.password == passWord)
                        return 1;
                    else
                        return -2;
                }
            }
        }
    }
}
