namespace AnalisadorDados.Application.Dto;

public record UsuarioRetornoSuperUsers(
    [property: JsonPropertyName("timestamp")] DateTime Timestamp,
    [property: JsonPropertyName("data")] IEnumerable<UsuarioCriacaoDto> Data
);