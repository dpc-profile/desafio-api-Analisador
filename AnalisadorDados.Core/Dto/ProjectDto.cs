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
    
    public static IEnumerable<ProjectEntity> ToEntity(IEnumerable<ProjectDto> dtos)
    {
        return dtos.Select(dto => new ProjectEntity
        {
            Name = dto.Name,
            Completed = dto.Completed
        }).ToList();
    }
    
    public static IEnumerable<ProjectDto> ToDto(IEnumerable<ProjectEntity> entities)
    {
        return entities.Select(entity => new ProjectDto(
            entity.Name,
            entity.Completed
        )).ToList();
    }
    
    [JsonPropertyName("name")] public string Name { get; }

    [JsonPropertyName("completed")] public bool Completed { get; }

  
}