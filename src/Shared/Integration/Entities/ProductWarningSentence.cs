using Shared.Integration.Entities.ChemicalAggregate;
using Shared.Integration.Entities.WarningSentenceAggregate;

namespace Shared.Integration.Entities;

public class ProductWarningSentence
{
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;

    public int WarningSentenceId { get; set; }
    public WarningSentence WarningSentence { get; set; } = null!;
}