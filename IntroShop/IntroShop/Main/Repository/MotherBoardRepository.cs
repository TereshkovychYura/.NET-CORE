using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Repository
{
    public class MotherBoardRepository : IAllMotherBoards
    {
        private readonly DBContent dbContent;
        public MotherBoardRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<MotherBoard> MotherBoards => dbContent.MotherBoard.Include(c => c.Category);
    }
}
