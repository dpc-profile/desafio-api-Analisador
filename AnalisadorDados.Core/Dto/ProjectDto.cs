using AnalisadorDados.Core.Entities;

namespace AnalisadorDados.Core.Dto;

public class ProjectDto
{
    [JsonConstructor]
    public ProjectDto(string name, bool completed)
    {
        Name = name;
        Completed = completed;
    }
    
    public static IEnumerable<PROJECT> ToEntity(IEnumerable<ProjectDto> dtos)
    {
        return dtos.Select(dto => new PROJECT
        {
            Name = dto.Name,
            Completed = dto.Completed
        }).ToList();
    }
    
    [JsonPropertyName("name")] public string Name { get; }

    [JsonPropertyName("completed")] public bool Completed { get; }

  
}