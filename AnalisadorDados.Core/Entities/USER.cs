namespace AnalisadorDados.Core.Entities;

public class USER
{
    public string Id { get; set; }

    public string Name {get; set;}

    public int Age {get; set;}

    public int Score {get; set;}

    public bool Active {get; set;}
    
    public string Country {get; set;}

    public TEAM Team {get; set;}

    public IEnumerable<LOG> Logs {get; set;}
    
}