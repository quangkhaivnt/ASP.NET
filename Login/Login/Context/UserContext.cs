using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Login.Context
{
    public class UserContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}