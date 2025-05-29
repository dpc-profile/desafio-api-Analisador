using AnalisadorDados.Core.Entities;

namespace AnalisadorDados.Repository.Configuration;

public class TeamEntityTypeConfiguration : IEntityTypeConfiguration<TEAM>
{
    public void Configure(EntityTypeBuilder<TEAM> builder)
    {
        builder.ToTable("TEAM");
        
        builder.HasKey(x => x.Id) ;
        builder.Property(p => p.Id)
            .HasColumnName("id")
            .IsRequired();

        builder.Property(p => p.Name)
            .HasColumnName("nome")
            .HasColumnType("varchar(100)")
            .IsRequired();
        
        builder.Property( p => p.Leader)
            .HasColumnName("leader")
            .IsRequired();

        //TODO: Mapear essa propriedade associando a outra tabela como uma foreing key
        builder.Property(p => p.Projects)
            .HasColumnName("projects");
    }
}