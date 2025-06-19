using AnalisadorDados.Core.Dto;
using AnalisadorDados.Core.Entities;

namespace AnalisadorDados.API.Dto;

public class UsuarioCriacaoDto
{
    [JsonConstructor]
    public UsuarioCriacaoDto(string id, string name, int age, int score, bool active, string country, 
        TeamDto teamDto, IEnumerable<LogDto> logs)
    {
        Id = id;
        Name = name;
        Age = age;
        Score = score;
        Active = active;
        Country = country;
        TeamDto = teamDto;
        Logs = logs;
    }
    
    public static UserEntity ToEntity(UsuarioCriacaoDto dto)
    {
        return new UserEntity
        {
            Id = dto.Id,
            Name = dto.Name,
            Age = dto.Age,
            Score = dto.Score,
            Active = dto.Active,
            Country = dto.Country,
            TeamEntity = TeamDto.ToEntity(dto.TeamDto),
            Logs = LogDto.ToEntity(dto.Logs).ToList()
        };
    }

    [JsonPropertyName("id")] public string Id { get; }

    [JsonPropertyName("name")] public string Name { get; }

    [JsonPropertyName("age")] public int Age { get; }

    [JsonPropertyName("score")] public int Score { get; }

    [JsonPropertyName("active")] public bool Active { get; }

    [JsonPropertyName("country")] public string Country { get; }

    [JsonPropertyName("team")] public TeamDto TeamDto { get; }

    [JsonPropertyName("logs")] public IEnumerable<LogDto> Logs { get; }
}