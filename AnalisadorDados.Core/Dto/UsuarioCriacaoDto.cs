using System.Text.Json.Serialization;

namespace AnalisadorDados.Core.Dto;

public record UsuarioCriacaoDto(
     [property: JsonPropertyName("id")] string Id,
     [property: JsonPropertyName("name")] string Name,
     [property: JsonPropertyName("age")] int Age,
     [property: JsonPropertyName("score")] int Score,
     [property: JsonPropertyName("active")] bool Active,
     [property: JsonPropertyName("country")] string Country,
     [property: JsonPropertyName("team")] Team Team,
     [property: JsonPropertyName("logs")] IEnumerable<Log> Logs
);
public record Log(
    [property: JsonPropertyName("date")] string Date,
    [property: JsonPropertyName("action")] string Action
);

public record Project(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("completed")] bool Completed
);

public record Team(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("leader")] bool Leader,
    [property: JsonPropertyName("projects")] IEnumerable<Project> Projects
);

