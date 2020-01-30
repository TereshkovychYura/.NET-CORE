﻿using IntroShop.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockProcessors : IAllProcessors
    {
        private readonly IProcessorCategory _categoryPhone = new MockCategory();
        public IEnumerable<Phone> Phones
        {
            get
            {
                return new List<Phone>
                {
                    new Phone
                    {
                        name = "Samsung S10",
                        description = "Best phone by Samsung",
                        img = "/img/samsung_galaxy_s10_6_128_gb.jpg",
                        price = 23000,
                        Category = _categoryPhone.AllCategories.First()
                    },
                    new Phone
                    {
                        name = "Nokia 3310",
                        description = "Old phone.",
                        img = "/img/Nokia_3310.jpg",
                        price = 700,
                        Category = _categoryPhone.AllCategories.Last()
                    }
                };
            }
        }
    }
}
