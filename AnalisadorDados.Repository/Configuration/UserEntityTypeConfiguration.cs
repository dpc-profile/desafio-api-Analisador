using AnalisadorDados.Core.Entities;

namespace AnalisadorDados.Repository.Configuration;

public class UserEntityTypeConfiguration : IEntityTypeConfiguration<USER>
{
    public void Configure(EntityTypeBuilder<USER> builder)
    {
        builder.ToTable("USER");
        
        builder.HasKey(x => x.Id) ;
        builder.Property(p => p.Id)
            .HasColumnName("id")
            .IsRequired();

        builder.Property(p => p.Name)
            .HasColumnName("nome")
            .HasColumnType("varchar(100)");

        builder.Property(p => p.Age)
            .HasColumnName("age");

        builder.Property(p => p.Score)
            .HasColumnName("score");

        builder.Property(p => p.Active)
            .HasColumnName("active");

        builder.Property(p => p.Country)
            .HasColumnName("country")
            .HasColumnType("varchar(20)");

        //TODO: Mapear essa propriedade associando a outra tabela como uma foreing key
        builder.Property(p => p.Team)
            .HasColumnName("team");

        //TODO: Mapear essa propriedade associando a outra tabela como uma foreing key
        builder.Property(p => p.Logs)
            .HasColumnName("logs");
    }
}