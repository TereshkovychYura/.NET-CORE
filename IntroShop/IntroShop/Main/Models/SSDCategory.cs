using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Models
{
    public class SSDCategory
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string categoryDescription { get; set; }
        public List<SSD> SSDs { get; set; }
    }
}
