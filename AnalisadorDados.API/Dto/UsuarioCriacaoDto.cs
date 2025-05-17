using System.Text.Json.Serialization;

namespace AnalisadorDados.API.Dto;

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

public class Log
{
    [JsonConstructor]
    public Log(string date, Action action)
    {
        this.Date = date;
        this.Action = action;
    }

    [JsonPropertyName("date")]
    public string Date { get; }

    [JsonPropertyName("action")]
    [JsonConverter(typeof(JsonStringEnumConverter<Action>))]
    public Action Action { get;}

}

public record Project(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("completed")] bool Completed
);

public record Team(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("leader")] bool Leader,
    [property: JsonPropertyName("projects")] IEnumerable<Project> Projects
);

public enum Action
{
    Invalid = 0,
    Login = 1,
    Logout = 2,
}