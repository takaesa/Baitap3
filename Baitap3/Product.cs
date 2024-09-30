﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    public class Product
    {
        public string ProductID {  get; set; }
        public string Name{ get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Origin { get; set; }
        public DateTime ExpirationDate { get; set; }

    }
}
