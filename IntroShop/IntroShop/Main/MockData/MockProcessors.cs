using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockProcessors : IAllProcessors
    {
        private readonly IProcessorCategory _categoryPhone = new MockProcessorCategory();
        public IEnumerable<Processor> Processors
        {
            get
            {
                return new List<Processor>
                {
                    new Processor
                    {
                        name = "AMD Ryzen 7 3700X 3.6GHz/32MB",
                        description = " Gamer rocessor by AMD",
                        img = "/img/copy_amd_ryzen_7_3800x.jpg",
                        price = 9576,
                        ProcessorCategory = _categoryPhone.AllProcessorCategories.First()
                    },
                    new Processor
                    {
                        name = "Intel Pentium G4500",
                        description = "Simple processor by Intel",
                        img = "/img/intel_pentium_g4500.jpg",
                        price = 1650,
                        ProcessorCategory = _categoryPhone.AllProcessorCategories.Last()
                    },
                    new Processor
                    {
                        name = "Intel Core i7-9700",
                        description = "Gamer processor by Intel",
                        img = "/img/intel_core_i7_9700.jpg",
                        price = 10250,
                        ProcessorCategory = _categoryPhone.AllProcessorCategories.First()
                    },
                    new Processor
                    {
                        name = "AMD Ryzen Threadripper 3960X",
                        description = "The best processor by AMD",
                        img = "/img/AMD_Ryzen_Threadripper_3960X.jpg",
                        price = 47084,
                        ProcessorCategory = _categoryPhone.AllProcessorCategories.First()
                    },
                    new Processor
                    {
                        name = "INTEL Core i9 9900",
                        description = "The best processor by Intel",
                        img = "/img/INTEL_Core_i9_9900.jpg",
                        price = 15500,
                        ProcessorCategory = _categoryPhone.AllProcessorCategories.First()
                    }
                };
            }
        }
    }
}
