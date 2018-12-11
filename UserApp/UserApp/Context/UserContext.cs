using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UserApp.Models;

namespace UserApp.Context
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}