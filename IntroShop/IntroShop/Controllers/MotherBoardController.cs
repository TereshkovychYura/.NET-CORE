using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroShop.Main.Interfaces;
using IntroShop.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IntroShop.Controllers
{
    public class MotherBoardController : Controller
    {
        private readonly IAllMotherBoards _allMotherBoards;
        private readonly IMotherBoardCategory _allCategories;

        public MotherBoardController(IAllMotherBoards iAllMotherBoards, IMotherBoardCategory iAllCategories)
        {
            _allMotherBoards = iAllMotherBoards;
            _allCategories = iAllCategories;
        }

        public ViewResult List()
        {
            ViewBag.Title = "MotherBoards";
            MotherBoardListViewModel obj = new MotherBoardListViewModel();
            obj.allMotherBoards = _allMotherBoards.MotherBoards;
            obj.currentMotherBoardCategory = "Best category";

            return View(obj);
        }
    }
}
