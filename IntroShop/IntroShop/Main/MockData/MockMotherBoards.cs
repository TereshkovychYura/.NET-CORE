using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockMotherBoards : IAllMotherBoards
    {
        private readonly IMotherBoardCategory _categoryPhone = new MockMotherBoardCategory();
        public IEnumerable<MotherBoard> MotherBoards
        {
            get
            {
                return new List<MotherBoard>
                {
                    new MotherBoard
                    {
                        name = "MSI B450 Tomahawk Max",
                        description = "Good mother board by MSI.",
                        img = "/img/msi_b450_tomahawk_max.jpg",
                        price = 3000,
                        Category = _categoryPhone.AllMotherBoardCategories.Last()
                    },
                    new MotherBoard
                    {
                        name = "Asus Prime X570-Pro",
                        description = "Very good mother board by ASUS",
                        img = "/img/asus_prime_x570_pro.jpg",
                        price = 6900,
                        Category = _categoryPhone.AllMotherBoardCategories.First()
                    },
                    new MotherBoard
                    {
                        name = "Gigabyte X399 Aorus Pro",
                        description = "The best mother board by Gigabyte",
                        img = "/img/gigabyte_x399_aorus_pro.jpg",
                        price = 7450,
                        Category = _categoryPhone.AllMotherBoardCategories.First()
                    },
                    new MotherBoard
                    {
                        name = "Asus Prime H310M-E R2.0",
                        description = "Simpel mother board by ASUS",
                        img = "/img/asus_prime_h310m_e_r2.jpg",
                        price = 2000,
                        Category = _categoryPhone.AllMotherBoardCategories.Last()
                    },
                    new MotherBoard
                    {
                        name = "ASRock X570 Steel Legend",
                        description = "Gamer mother board by ASRock",
                        img = "/img/asrock_x570_steel_legend.jpg",
                        price = 6185,
                        Category = _categoryPhone.AllMotherBoardCategories.First()
                    }
                };
            }
        }
    }
}
