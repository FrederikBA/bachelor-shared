using Shared.Integration.Entities.WarningSentenceAggregate;
using Shared.Integration.Interfaces;

namespace Shared.Integration.Entities.ChemicalAggregate;

public class Product : BaseEntity, IAggregateRoot
{
    public string? Name { get; set; }
    public int ProductCategoryId { get; set; }
    public int ProducerId { get; set; }
    public int ProductStatusId { get; set; }
    public ProductCategory? ProductCategory { get; set; }
    public Producer? Producer { get; set; }
    public ProductStatus? ProductStatus { get; set; }
    public List<WarningSentence>? WarningSentences { get; set; } = new();
}