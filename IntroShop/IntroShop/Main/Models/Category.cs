using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categotyName { get; set; }
        public string categoryDescription { get; set; }
        public List<Phone> phones { get; set; }
    }
}
