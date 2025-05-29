namespace AnalisadorDados.Core.Entities;

public class TEAM
{
    public int Id { get; set; }
    
    public string Name {get; set;}
    
    public bool Leader {get; set;}
    
    public List<PROJECT>? Projects {get; set;}
    
}