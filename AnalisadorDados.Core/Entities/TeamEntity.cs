namespace AnalisadorDados.Core.Entities;

[Table("TEAM")]
public class TeamEntity
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [ForeignKey(nameof(UserEntity))]
    public string UserKey { get; set; }
    public UserEntity UserEntity { get; set; }
    
    [Column("name", TypeName = "varchar(100)")]
    public string Name {get; set;}
    
    [Column("leader")]
    public bool Leader {get; set;}
    
    [Column("projects")]
    public ICollection<ProjectEntity> Projects {get; init;} = new List<ProjectEntity>();
    
}