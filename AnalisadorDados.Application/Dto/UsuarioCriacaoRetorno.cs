namespace AnalisadorDados.Application.Dto;

public record UsuarioCriacaoRetorno(
     [property: JsonPropertyName("message")] string Message,
     [property: JsonPropertyName("user_count")] int UserCount
    );