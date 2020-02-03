using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockSSDCategory : ISSDCategory
    {
        public IEnumerable<SSDCategory> AllSSDCategories
        {
            get
            {
                return new List<SSDCategory>
                {
                    new SSDCategory{ categoryName= "Up to 500 GB", categoryDescription= "SSD with less than 500 GB memory"},
                    new SSDCategory{ categoryName= "More than 500 GB", categoryDescription= "SSD with more than 500 GB memory"}
                };
            }
        }
    }
}
