using Microsoft.EntityFrameworkCore;
using _19_Exercicio_CRUD.BD.Models;

namespace _19_Exercicio_CRUD.BD.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<_19_Exercicio_CRUD.BD.Models.Gym> Gym { get; set; } = default!;
        
    }
}