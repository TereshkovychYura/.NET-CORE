using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main
{
    public class DBObjects
    {
        public static void Initial(DBContent content)
        {
            #region Phone
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Phone.Any())
            {
                content.AddRange(
                   new Phone
                   {
                       name = "Samsung S10",
                       description = "Best phone by Samsung Lorem ipsum dolor sin amet lorem ",
                       img = "/img/samsung_galaxy_s10_6_128_gb.jpg",
                       price = 23000,
                       Category = Categories["Flagman"]
                   },
                    new Phone
                    {
                        name = "Nokia 3310",
                        description = "Old phone. Lorem ipsum dolor sin amet lorem ",
                        img = "/img/Nokia_3310.jpg",
                        price = 700,
                        Category = Categories["Flagman"]
                    }
                );
            }
            #endregion

            #region MotherBoard
            if (!content.MotherBoardCategory.Any())
            {
                content.MotherBoardCategory.AddRange(MBCategories.Select(c => c.Value));
            }
            if (!content.MotherBoard.Any())
            {
                content.AddRange(
                   new MotherBoard
                   {
                       name = "MSI B450 Tomahawk Max",
                       description = "Good mother board by MSI.",
                       img = "/img/msi_b450_tomahawk_max.jpg",
                       price = 3000,
                       Category = MBCategories["Simple"]
                   },
                    new MotherBoard
                    {
                        name = "Asus Prime X570-Pro",
                        description = "Very good mother board by ASUS",
                        img = "/img/asus_prime_x570_pro.jpg",
                        price = 6900,
                        Category = MBCategories["Gamer"]
                    },
                    new MotherBoard
                    {
                        name = "Gigabyte X399 Aorus Pro",
                        description = "The best mother board by Gigabyte",
                        img = "/img/gigabyte_x399_aorus_pro.jpg",
                        price = 7450,
                        Category = MBCategories["Gamer"]
                    },
                    new MotherBoard
                    {
                        name = "Asus Prime H310M-E R2.0",
                        description = "Simpel mother board by ASUS",
                        img = "/img/asus_prime_h310m_e_r2.jpg",
                        price = 2000,
                        Category = MBCategories["Simple"]
                    },
                    new MotherBoard
                    {
                        name = "ASRock X570 Steel Legend",
                        description = "Gamer mother board by ASRock",
                        img = "/img/asrock_x570_steel_legend.jpg",
                        price = 6185,
                        Category = MBCategories["Gamer"]
                    }
                );
            }
            #endregion

            #region Processor
            if (!content.ProcessorCategory.Any())
            {
                content.ProcessorCategory.AddRange(ProcCategories.Select(c => c.Value));
            }
            if (!content.Processor.Any())
            {
                content.AddRange(
                   new Processor
                   {
                       name = "AMD Ryzen 7 3700X 3.6GHz/32MB",
                       description = " Gamer rocessor by AMD",
                       img = "/img/copy_amd_ryzen_7_3800x.jpg",
                       price = 9576,
                       ProcessorCategory = ProcCategories["Gamer"]
                   },
                    new Processor
                    {
                        name = "Intel Pentium G4500",
                        description = "Simple processor by Intel",
                        img = "/img/intel_pentium_g4500.jpg",
                        price = 1650,
                        ProcessorCategory = ProcCategories["Simple"]
                    },
                    new Processor
                    {
                        name = "Intel Core i7-9700",
                        description = "Gamer processor by Intel",
                        img = "/img/intel_core_i7_9700.jpg",
                        price = 10250,
                        ProcessorCategory = ProcCategories["Gamer"]
                    },
                    new Processor
                    {
                        name = "AMD Ryzen Threadripper 3960X",
                        description = "The best processor by AMD",
                        img = "/img/AMD_Ryzen_Threadripper_3960X.jpg",
                        price = 47084,
                        ProcessorCategory = ProcCategories["Gamer"]
                    },
                    new Processor
                    {
                        name = "INTEL Core i9 9900",
                        description = "The best processor by Intel",
                        img = "/img/INTEL_Core_i9_9900.jpg",
                        price = 15500,
                        ProcessorCategory = ProcCategories["Gamer"]
                    }
                );
            }
            #endregion

            #region SSD     
            if (!content.SSDCategory.Any())
            {
                content.SSDCategory.AddRange(SSDCategories.Select(c => c.Value));
            }
            if (!content.SSD.Any())
            {
                content.AddRange(
                   new SSD
                   {
                       name = "Samsung 860 Pro series 1TB 2.5",
                       description = "SSD with big capacity",
                       img = "/img/samsung_mz_76p_1TB.jpg",
                       price = 8000,
                       SSDCategory = SSDCategories["More than 500 GB"]
                   },
                    new SSD
                    {
                        name = "Kingston SSD HyperX Fury 3D 480GB 2.5",
                        description = "SSD with normal capacity",
                        img = "/img/kingston_kc_s44_480GB.jpg",
                        price = 1800,
                        SSDCategory = SSDCategories["Up to 500 GB"]
                    },
                    new SSD
                    {
                        name = "Goodram CX400 512GB 2.5",
                        description = "SSD by Goodram",
                        img = "/img/goodram_ssdpr_cx400_512gb.jpg",
                        price = 1650,
                        SSDCategory = SSDCategories["More than 500 GB"]
                    },
                    new SSD
                    {
                        name = "Seagate 3.5 10TB",
                        description = "SSD with 10TB memory by Seagate ",
                        img = "/img/Seagate_3.5_10TB.jpg",
                        price = 11498,
                        SSDCategory = SSDCategories["More than 500 GB"]
                    },
                    new SSD
                    {
                        name = "Kingston SSD HyperX Fury 3D 120GB 2.5",
                        description = "SSD with low capacity",
                        img = "/img/kingston_kc_s44_120GB.jpg",
                        price = 729,
                        SSDCategory = SSDCategories["Up to 500 GB"]
                    }
                );
            }
            #endregion
            content.SaveChanges();
        }
        #region PhoneCategory
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Flagman", categoryDescription = "Phone with hight price and extra functions" },
                        new Category { categoryName = "Budget", categoryDescription = "Phone with low price without extra fubctions" }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category item in list)
                    {
                        category.Add(item.categoryName, item);
                    }
                }
                return category;
            }

        }
        #endregion

        #region MotherBoardCategory
        private static Dictionary<string, MotherBoardCategory> MBcategory;
        public static Dictionary<string, MotherBoardCategory> MBCategories
        {
            get
            {
                if (MBcategory == null)
                {
                    var list = new MotherBoardCategory[]
                    {
                        new MotherBoardCategory{ categoryName= "Gamer", categoryDescription= "Mother board with hight price and extra functions"},
                        new MotherBoardCategory{ categoryName= "Simple", categoryDescription= "Mother board low price without extra functions"}
                    };
                    MBcategory = new Dictionary<string, MotherBoardCategory>();
                    foreach (MotherBoardCategory item in list)
                    {
                        MBcategory.Add(item.categoryName, item);
                    }
                }
                return MBcategory;
            }

        }
        #endregion

        #region ProcessorCategory
        private static Dictionary<string, ProcessorCategory> ProcCategory;
        public static Dictionary<string, ProcessorCategory> ProcCategories
        {
            get
            {
                if (ProcCategory == null)
                {
                    var list = new ProcessorCategory[]
                    {
                        new ProcessorCategory{ categoryName= "Gamer", categoryDescription= "Processor with hight price and extra functions"},
                        new ProcessorCategory{ categoryName= "Simple", categoryDescription= "Processor with low price without extra functions"}
                    };
                    ProcCategory = new Dictionary<string, ProcessorCategory>();
                    foreach (ProcessorCategory item in list)
                    {
                        ProcCategory.Add(item.categoryName, item);
                    }
                }
                return ProcCategory;
            }

        }
        #endregion

        #region SSDCaregory
        private static Dictionary<string, SSDCategory> SSDcategory;
        public static Dictionary<string, SSDCategory> SSDCategories
        {
            get
            {
                if (SSDcategory == null)
                {
                    var list = new SSDCategory[]
                    {
                        new SSDCategory{ categoryName= "Up to 500 GB", categoryDescription= "SSD with less than 500 GB memory"},
                        new SSDCategory{ categoryName= "More than 500 GB", categoryDescription= "SSD with more than 500 GB memory"}
                    };
                    SSDcategory = new Dictionary<string, SSDCategory>();
                    foreach (SSDCategory item in list)
                    {
                        SSDcategory.Add(item.categoryName, item);
                    }
                }
                return SSDcategory;
            }

        }
        #endregion
    }
}
