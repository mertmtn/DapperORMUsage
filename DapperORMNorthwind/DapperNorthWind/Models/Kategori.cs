using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperNorthWind.Models
{
    public class Kategori
    {
        public string CategoryName { get; set; }

        public int CategoryId { get; set; }

        public string Description { get; set; }

        public Urunler Urun { get; set; }
    }


}
 