using FoodiesMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodiesMVC.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<Categoria> Categoria { get; set; }
    }
}
