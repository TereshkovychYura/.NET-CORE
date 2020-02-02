using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroShop.Main.Interfaces;
using IntroShop.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IntroShop.Controllers
{
    public class ProcessorController :Controller
    {
        private readonly IAllProcessors _allProcessors;
        private readonly IProcessorCategory _allCategories;

        public ProcessorController(IAllProcessors iAllProcessors, IProcessorCategory iAllCategories)
        {
            _allProcessors = iAllProcessors;
            _allCategories = iAllCategories;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Processors";
            ProcessorListViewModel obj = new ProcessorListViewModel();
            obj.allProcessors = _allProcessors.Processors;
            obj.currentCategory = "Best category";

            return View(obj);
        }
    }
}
