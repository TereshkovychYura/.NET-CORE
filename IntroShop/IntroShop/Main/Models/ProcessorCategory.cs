﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Models
{
    public class ProcessorCategory
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string categoryDescription { get; set; }
        public List<Processor> processors { get; set; }
    }
}
