using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Models
{
    public class MotherBoard
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string img { get; set; }
        public uint price { get; set; }
        public virtual MotherBoardCategory Category { get; set; }
    }
}
