using System.Text.Json.Serialization;

namespace AnalisadorDados.API.Dto;

public record UsuarioCriacaoRetorno(
     [property: JsonPropertyName("message")] string Message,
     [property: JsonPropertyName("user_count")] int UserCount
    );