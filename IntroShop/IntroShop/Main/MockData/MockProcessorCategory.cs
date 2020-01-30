using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockProcessorCategory : IProcessorCategory
    {
        public IEnumerable<ProcessorCategory> AllProcessorCategories
        {
            get
            {
                return new List<ProcessorCategory>
                {
                    new ProcessorCategory{ categotyName= "Gamer", categoryDescription= "Processor with hight price and extra functions"},
                    new ProcessorCategory{ categotyName= "Simple", categoryDescription= "Processor with low price without extra functions"}
                };
            }
        }
    }
}
