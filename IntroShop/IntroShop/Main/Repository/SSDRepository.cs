using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Repository
{
    public class SSDRepository : IAllSSDs
    {
        private readonly DBContent dbContent;
        public SSDRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<SSD> SSDs => dbContent.SSD.Include(c => c.SSDCategory);
    }
}
