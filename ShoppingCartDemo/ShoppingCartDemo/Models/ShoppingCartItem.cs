﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCartDemo.Models
{
    public class ShoppingCartItem
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}