using AnalisadorDados.Core.Entities;

namespace AnalisadorDados.Repository.Entities;

public class TEAM
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name", TypeName = "varchar(100)")]
    public string Name {get; set;}
    
    [Column("leader")]
    public bool Leader {get; set;}
    
    [Column("projects")]
    public List<PROJECT> Projects {get; set;}
    
}