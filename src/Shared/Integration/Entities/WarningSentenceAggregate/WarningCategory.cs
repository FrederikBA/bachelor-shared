namespace Shared.Integration.Entities.WarningSentenceAggregate;

public class WarningCategory : BaseEntity
{
    public string? Text { get; set; }
    public int WarningTypeId { get; set; }
    public int SortOrder { get; set; }
    public WarningType? WarningType { get; set; }
    public List<WarningSentence>? WarningSentences { get; set; }
}