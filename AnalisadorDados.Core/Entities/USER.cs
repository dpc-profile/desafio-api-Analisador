namespace AnalisadorDados.Repository.Entities;

public class USER
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
    public TEAM Team {get; set;}
    
    [Column("logs")]    
    public IEnumerable<LOG> Logs {get; set;}
    
}