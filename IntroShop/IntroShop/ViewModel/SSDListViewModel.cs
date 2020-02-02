using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.ViewModel
{
    public class SSDListViewModel
    {
        public IEnumerable<SSD> allSSDs { get; set; }

        public string currentCategory { get; set; }
    }
}
