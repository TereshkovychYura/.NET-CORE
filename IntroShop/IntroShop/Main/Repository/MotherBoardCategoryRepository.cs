using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Repository
{
    public class MotherBoardCategoryRepository : IMotherBoardCategory
    {
        private readonly DBContent dbContent;
        public MotherBoardCategoryRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<MotherBoardCategory> AllMotherBoardCategories => dbContent.MotherBoardCategory;
    }
}
