namespace Shared.Integration.Entities.WarningSentenceAggregate;

public class WarningType : BaseEntity
{
    public string? Type { get; set; }
    public int Priority { get; set; }
    public List<WarningCategory>? WarningCategories { get; set; }
}