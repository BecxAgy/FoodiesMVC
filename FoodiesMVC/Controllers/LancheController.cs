﻿using FoodiesMVC.Repositories;
using FoodiesMVC.Repositories.Interfaces;
using FoodiesMVC.ViewModels;
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
            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _repository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Todos os Lanches";
            return View(lanchesListViewModel);
        }

        public RedirectToActionResult ToggleFavorite(int lancheId)
        {
            // Alterna o estado do item favorito no repositório
            _repository.ToggleFavorite(lancheId);


            return RedirectToAction("List");
            
        }

    }
}
