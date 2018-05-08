using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperNorthWind.Models
{
    public class Siparis
    {
        public int OrderID { get; set; }

        public string ProductName { get; set; }

        public Urunler Products { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime ShippedDate { get; set; }

        public DateTime RequiredDate { get; set; }

        public SiparisDetay OrderDetails { get; set; }
    }
}
 