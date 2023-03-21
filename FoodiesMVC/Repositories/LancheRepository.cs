using FoodiesMVC.Context;
using FoodiesMVC.Models;
using FoodiesMVC.Repositories.Interfaces;

namespace FoodiesMVC.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches;
    }
}
