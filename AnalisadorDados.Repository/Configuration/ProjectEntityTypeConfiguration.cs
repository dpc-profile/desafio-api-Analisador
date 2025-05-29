using AnalisadorDados.Core.Entities;

namespace AnalisadorDados.Repository.Configuration;

public class ProjectEntityTypeConfiguration : IEntityTypeConfiguration<PROJECT>
{
    public void Configure(EntityTypeBuilder<PROJECT> builder)
    {
        builder.ToTable("PROJECTS");

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id)
            .HasColumnName("id")
            .IsRequired();

        builder.Property(p => p.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(100)")
            .IsRequired();

        builder.Property(p => p.Completed)
            .HasColumnName("completed")
            .IsRequired();
        
    }
}