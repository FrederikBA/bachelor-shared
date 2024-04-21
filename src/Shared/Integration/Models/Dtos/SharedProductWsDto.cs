using System.Text.Json.Serialization;

namespace Shared.Integration.Models.Dtos;

public class SharedProductWsDto
{
    [JsonPropertyName("warningSentenceIds")]
    public List<int> WarningSentenceIds { get; set; }
}