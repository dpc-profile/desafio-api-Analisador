using AnalisadorDados.Core.Entities;

namespace AnalisadorDados.Core.Dto;

public class TeamDto
{
    [JsonConstructor]
    public TeamDto(string name, bool leader, IEnumerable<ProjectDto> projects)
    {
        Name = name;
        Leader = leader;
        Projects = projects;
    }
    
    public static TEAM ToEntity(TeamDto dto)
    {
        return new TEAM
        {
            Name = dto.Name,
            Leader = dto.Leader,
            Projects = ProjectDto.ToEntity(dto.Projects).ToList(),
        };
    }
    
    [JsonPropertyName("name")] public string Name { get; }
    [JsonPropertyName("leader")] public bool Leader { get; }
    [JsonPropertyName("projects")] public IEnumerable<ProjectDto> Projects { get; }
}