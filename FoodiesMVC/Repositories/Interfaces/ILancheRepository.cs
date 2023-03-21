using FoodiesMVC.Context;
using FoodiesMVC.Models;

namespace FoodiesMVC.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
    }
}
