using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Repository
{
    public class ProcessorRepository : IAllProcessors
    {
        private readonly DBContent dbContent;
        public ProcessorRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<Processor> Processors => dbContent.Processor.Include(c => c.ProcessorCategory);
    }
}
