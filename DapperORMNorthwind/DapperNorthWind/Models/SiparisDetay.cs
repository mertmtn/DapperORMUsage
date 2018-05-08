using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperNorthWind.Models
{
    public class SiparisDetay
    {
        public string ProductName { get; set; }

        public Urunler Products { get; set; }

        public int OrderID { get; set; }

        public int Quantity{ get; set; }

        public double UnitPrice { get; set; }

        public double Discount { get; set; }
    }
}
