using IntroShop.Main.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main
{
    public class DBContent : DbContext
    {
        public DBContent(DbContextOptions<DBContent> options) : base(options)
        {

        }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Category> Category { get; set; }

        public DbSet<MotherBoard> MotherBoard { get; set; }
        public DbSet<MotherBoardCategory> MotherBoardCategory { get; set; }

        public DbSet<Processor> Processor { get; set; }
        public DbSet<ProcessorCategory> ProcessorCategory { get; set; }

        public DbSet<SSD> SSD { get; set; }
        public DbSet<SSDCategory> SSDCategory{ get; set; }
    }
}
