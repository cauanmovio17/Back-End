using Microsoft.EntityFrameworkCore;
using _18_CRUD_BD.Models;

namespace _18_CRUD_BD.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<_18_CRUD_BD.Models.Jogo> Jogo { get; set; } = default!;
        //No meu DbSet carregara todos os jogos salvos no banco dados
     
        
    }
}