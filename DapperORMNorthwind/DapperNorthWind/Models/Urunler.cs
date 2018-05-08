﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperNorthWind.Models
{
    public class Urunler
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int UnitsInStock { get; set; }

        public double UnitPrice { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public Kategori Kategori { get; set; }

        public SiparisDetay OrderDetails { get; set; }
    }
}
 