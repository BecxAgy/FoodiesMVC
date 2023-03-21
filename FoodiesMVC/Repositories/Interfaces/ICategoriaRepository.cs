using FoodiesMVC.Models;

namespace FoodiesMVC.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
