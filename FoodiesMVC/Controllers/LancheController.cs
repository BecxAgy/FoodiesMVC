using FoodiesMVC.Repositories;
using FoodiesMVC.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodiesMVC.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _repository;

        public LancheController(ILancheRepository repository)
        {
            _repository = repository;
        }

        public IActionResult List()
        {
            var lanches = _repository.Lanches;
            return View(lanches);
        }
    }
}
