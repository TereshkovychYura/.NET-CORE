using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Repository
{
    public class SSDCategoryRepository : ISSDCategory
    {
        private readonly DBContent dbContent;
        public SSDCategoryRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<SSDCategory> AllSSDCategories => dbContent.SSDCategory;
    }
}
