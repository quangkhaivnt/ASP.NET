using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UserApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        
        public string UserName { get; set; }

        
        public string Password { get; set; }
        
    }
}