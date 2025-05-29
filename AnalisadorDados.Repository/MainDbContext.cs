using AnalisadorDados.Core.Entities;
using AnalisadorDados.Repository.Configuration;

namespace AnalisadorDados.Repository;

public class MainDbContext : DbContext
{
    public MainDbContext(DbContextOptions<MainDbContext> options) : base(options){}
    
    // Adicionar aqui o mapeamento dos dbset
    // https://learn.microsoft.com/en-us/ef/core/modeling/
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new ProjectEntityTypeConfiguration().Configure(modelBuilder.Entity<PROJECT>());
        new TeamEntityTypeConfiguration().Configure(modelBuilder.Entity<TEAM>());
        new LogEntityTypeConfiguration().Configure(modelBuilder.Entity<LOG>());
        new UserEntityTypeConfiguration().Configure(modelBuilder.Entity<USER>());
    }
}