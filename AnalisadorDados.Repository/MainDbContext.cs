using AnalisadorDados.Core.Entities;

namespace AnalisadorDados.Repository;

public class MainDbContext : DbContext
{
    public MainDbContext(DbContextOptions<MainDbContext> options) : base(options){}
    
    public DbSet<ProjectEntity> PROJETS { get; set; }
    public DbSet<TeamEntity> TEAM { get; set; }
    public DbSet<UserEntity> USER { get; set; }
    
    // Adicionar aqui o mapeamento dos dbset
    // https://learn.microsoft.com/en-us/ef/core/modeling/
    
    # region DbSet
    
    public DbSet<ProjectEntity> Project()
    {
        return Set<ProjectEntity>();
    }
    
    public DbSet<TeamEntity> Team()
    {
        return Set<TeamEntity>();
    }
    
    public DbSet<UserEntity> User()
    {
        return Set<UserEntity>();
    }
    
    #endregion
}
