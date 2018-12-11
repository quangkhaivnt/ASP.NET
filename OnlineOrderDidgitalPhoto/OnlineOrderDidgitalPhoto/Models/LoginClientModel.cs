﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineOrderDidgitalPhoto.Models
{
    public class LoginClientModel
    {
        [Required(ErrorMessage = "Mời nhập Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mời nhập Password")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}