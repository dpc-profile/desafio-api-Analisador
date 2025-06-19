
namespace AnalisadorDados.Core.Entities;

[Table("PROJECT")]
public class ProjectEntity
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name", TypeName = "varchar(100)")]
    public string Name {get; set;}
    
    [Column("completed")]
    public bool Completed {get; set;}
}