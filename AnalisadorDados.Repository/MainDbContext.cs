using AnalisadorDados.Core.Entities;

namespace AnalisadorDados.Repository;

public class MainDbContext : DbContext
{

    public MainDbContext(DbContextOptions<MainDbContext> options) : base(options){}
    
    public DbSet<PROJECT> Projetos { get; set; }
    public DbSet<TEAM> Team { get; set; }
    public DbSet<USER> User { get; set; }
    
    // Adicionar aqui o mapeamento dos dbset
    // https://learn.microsoft.com/en-us/ef/core/modeling/
}