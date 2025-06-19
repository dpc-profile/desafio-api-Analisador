namespace AnalisadorDados.Core.Entities;

[Table("USER")]
public class UserEntity
{
    [Key]
    [Column("id")]
    [Required]
    public string Id { get; set; }
    
    [Column("name", TypeName = "varchar(100)")]
    public string Name {get; set;}
    
    [Column("age")]    
    public int Age {get; set;}
    
    [Column("score")]    
    public int Score {get; set;}
    
    [Column("active")]    
    public bool Active {get; set;}
        
    [Column("contry", TypeName = "varchar(20)")]
    public string Country {get; set;}
    
    [Column("team")]    
    public TeamEntity TeamEntity {get; set;}

    [Column("logs")] 
    public ICollection<LogEntity> Logs { get; set; } = new List<LogEntity>();

}