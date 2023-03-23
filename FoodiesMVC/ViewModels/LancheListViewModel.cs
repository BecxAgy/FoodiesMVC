using FoodiesMVC.Models;

namespace FoodiesMVC.ViewModels
{
    public class LancheListViewModel
    {
        public List<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
