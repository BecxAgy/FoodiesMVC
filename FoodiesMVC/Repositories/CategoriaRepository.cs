using FoodiesMVC.Context;
using FoodiesMVC.Models;
using FoodiesMVC.Repositories.Interfaces;

namespace FoodiesMVC.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
