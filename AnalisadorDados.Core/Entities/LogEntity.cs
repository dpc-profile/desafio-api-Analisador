using AnalisadorDados.Core.Dto;

namespace AnalisadorDados.Core.Entities;

[Table("LOG")]
public class LogEntity
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("date")]
    public DateOnly Date {get; set;}
    
    [Column("action")]
    public EnumAction Action {get; set;}
}