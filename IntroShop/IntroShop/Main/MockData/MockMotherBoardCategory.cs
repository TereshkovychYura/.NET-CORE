using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockMotherBoardCategory : IMotherBoardCategory
    {
        public IEnumerable<MotherBoardCategory> AllMotherBoardCategories
        {
            get
            {
                return new List<MotherBoardCategory>
                {
                    new MotherBoardCategory{ categotyName= "Gamer", categoryDescription= "Mother board with hight price and extra functions"},
                    new MotherBoardCategory{ categotyName= "Simple", categoryDescription= "Mother board low price without extra functions"}
                };
            }
        }
    }
}
