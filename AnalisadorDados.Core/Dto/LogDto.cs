using AnalisadorDados.Core.Entities;

namespace AnalisadorDados.Core.Dto;

public class LogDto
{
    [JsonConstructor]
    public LogDto(string date, EnumAction enumAction)
    {
        this.Date = date;
        this.EnumAction = enumAction;
    }
    
    public static IEnumerable<LogEntity> ToEntity(IEnumerable<LogDto> dtos)
    {
        return dtos.Select(dto => new LogEntity
        {
            Date = DateOnly.Parse(dto.Date),
            Action = dto.EnumAction
        });
    }

    [JsonPropertyName("date")] public string Date { get; }

    [JsonPropertyName("action")]
    [JsonConverter(typeof(JsonStringEnumConverter<EnumAction>))] 
    public EnumAction EnumAction { get;}

}