using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Repository
{
    public class ProcessorCategoryRepository : IProcessorCategory
    {
        private readonly DBContent dbContent;
        public ProcessorCategoryRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<ProcessorCategory> AllProcessorCategories => dbContent.ProcessorCategory;
    }
}
