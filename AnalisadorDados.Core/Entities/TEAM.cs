namespace AnalisadorDados.Core.Entities;

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
    public ICollection<PROJECT> Projects {get; set;} = new List<PROJECT>();
    
}