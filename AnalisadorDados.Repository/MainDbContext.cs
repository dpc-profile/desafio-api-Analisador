using AnalisadorDados.Core.Entities;

namespace AnalisadorDados.Repository;

public class MainDbContext : DbContext
{

    public MainDbContext(DbContextOptions<MainDbContext> options) : base(options){}
    
    public DbSet<ProjectEntity> Projetos { get; set; }
    public DbSet<TeamEntity> Team { get; set; }
    public DbSet<UserEntity> User { get; set; }
    
    // Adicionar aqui o mapeamento dos dbset
    // https://learn.microsoft.com/en-us/ef/core/modeling/
}