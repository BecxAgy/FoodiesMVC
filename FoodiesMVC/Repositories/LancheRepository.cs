using FoodiesMVC.Context;
using FoodiesMVC.Models;
using FoodiesMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

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

        public IEnumerable<Lanche> LanchesFavoritos => _context.Lanches.Where(lanche => lanche.IsFavorito)
            .Include(c => c.Categoria);

       

        public Lanche GetLancheById(int id)
        {
           return  _context.Lanches.FirstOrDefault(l => l.LancheId == id);
        }

        public void ToggleFavorite(int itemId)
        {
            var item = _context.Lanches.FirstOrDefault(i => i.LancheId == itemId);
            if (item != null)
            {
                if (item.IsFavorito)
                {
                    item.IsFavorito = false;
                }
                else
                {
                    item.IsFavorito = true;
                }
                _context.SaveChanges();
            }
        }

    }
}
