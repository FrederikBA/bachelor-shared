using Shared.Integration.Entities.ChemicalAggregate;
using Shared.Integration.Interfaces;

namespace Shared.Integration.Entities.WarningSentenceAggregate;

public class WarningSentence : BaseEntity, IAggregateRoot
{
    public string? Code { get; set; }
    public string? Text { get; set; }
    public int WarningCategoryId { get; set; }
    public int WarningPictogramId { get; set; }
    public int WarningSignalWordId { get; set; }
    public WarningCategory? WarningCategory { get; set; }
    public WarningSignalWord? WarningSignalWord { get; set; }
    public WarningPictogram? WarningPictogram { get; set; }
    public List<Product>? Products { get; set; } = new();
}