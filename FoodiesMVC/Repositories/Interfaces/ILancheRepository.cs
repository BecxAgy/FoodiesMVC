using FoodiesMVC.Context;
using FoodiesMVC.Models;

namespace FoodiesMVC.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesFavoritos { get; }
        Lanche GetLancheById(int id);
        void ToggleFavorite(int id);
    }
}
