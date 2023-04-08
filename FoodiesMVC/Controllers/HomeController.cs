using FoodiesMVC.Models;
using FoodiesMVC.Repositories.Interfaces;
using FoodiesMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FoodiesMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _repository;

        public HomeController(ILancheRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var homeVM = new HomeViewModel
            {
                LanchesFavoritos = _repository.LanchesFavoritos
           
            };

            return View(homeVM);
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}