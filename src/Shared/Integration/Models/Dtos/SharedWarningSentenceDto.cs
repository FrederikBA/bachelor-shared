using System.Text.Json.Serialization;

namespace Shared.Integration.Models.Dtos;

public class SharedWarningSentenceDto
{
    [JsonPropertyName("warningSentenceId")]
    public int WarningSentenceId { get; set; }

    [JsonPropertyName("warningSentenceCode")]
    public string? WarningSentenceCode { get; set; }
}