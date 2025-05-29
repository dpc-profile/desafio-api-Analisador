using AnalisadorDados.Core.Entities;

namespace AnalisadorDados.Repository.Configuration;

public class LogEntityTypeConfiguration : IEntityTypeConfiguration<LOG>
{
    public void Configure(EntityTypeBuilder<LOG> builder)
    {
        builder.ToTable("LOG");
        
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasColumnName("id")
            .HasColumnType("int");

        builder.Property(x => x.Date)
            .HasColumnName("date");
        
        builder.Property(x => x.Action)
            .HasColumnName("action")
            .HasColumnType("int");
    }
}