using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroShop.Main.Interfaces;
using IntroShop.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IntroShop.Controllers
{
    public class SSDController :Controller
    {
        private readonly IAllSSDs _allSSDs;
        private readonly ISSDCategory _allCategories;

        public SSDController(IAllSSDs iAllSSDs, ISSDCategory iAllCategories)
        {
            _allSSDs = iAllSSDs;
            _allCategories = iAllCategories;
        }

        public ViewResult List()
        {
            ViewBag.Title = "SSDs";
            SSDListViewModel obj = new SSDListViewModel();
            obj.allSSDs = _allSSDs.SSDs;
            obj.currentCategory = "Best category";

            return View(obj);
        }
    }
}
