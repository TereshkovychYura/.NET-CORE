using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockSSD : IAllSSDs
    {
        private readonly ISSDCategory _categorySSd = new MockSSDCategory();
        public IEnumerable<SSD> SSDs
        {
            get
            {
                return new List<SSD>
                {
                    new SSD
                    {
                        name = "Samsung 860 Pro series 1TB 2.5",
                        description = "SSD with big capacity",
                        img = "/img/samsung_mz_76p_1TB.jpg",
                        price = 8000,
                        SSDCategory = _categorySSd.AllSSDCategories.Last()
                    },
                    new SSD
                    {
                        name = "Kingston SSD HyperX Fury 3D 480GB 2.5",
                        description = "SSD with normal capacity",
                        img = "/img/kingston_kc_s44_480GB.jpg",
                        price = 1800,
                        SSDCategory = _categorySSd.AllSSDCategories.First()
                    },
                    new SSD
                    {
                        name = "Goodram CX400 512GB 2.5",
                        description = "SSD by Goodram",
                        img = "/img/goodram_ssdpr_cx400_512gb.jpg",
                        price = 1650,
                        SSDCategory = _categorySSd.AllSSDCategories.Last()
                    },
                    new SSD
                    {
                        name = "Seagate 3.5 10TB",
                        description = "SSD with 10TB memory by Seagate ",
                        img = "/img/Seagate_3.5_10TB.jpg",
                        price = 11498,
                        SSDCategory = _categorySSd.AllSSDCategories.Last()
                    },
                    new SSD
                    {
                        name = "Kingston SSD HyperX Fury 3D 120GB 2.5",
                        description = "SSD with low capacity",
                        img = "/img/kingston_kc_s44_120GB.jpg",
                        price = 729,
                        SSDCategory = _categorySSd.AllSSDCategories.First()
                    }
                };
            }
        }
    }
}
