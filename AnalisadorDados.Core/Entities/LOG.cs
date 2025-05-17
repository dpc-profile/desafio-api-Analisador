namespace AnalisadorDados.Repository.Entities;

public class LOG
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("date")]
    public DateOnly Date {get; set;}
    
    [Column("action")]
    public required Action Action {get; set;}
}