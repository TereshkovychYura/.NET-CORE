﻿using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Interfaces
{
    interface IProcessorCategory
    {
        IEnumerable<ProcessorCategory> AllProcessorCategories { get; }
    }
}