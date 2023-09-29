using Cartopia.Domain.Commons;

namespace Cartopia.Domain.Entities;

public class District : Auditable
{
    public string NameUz { get; set; }
    public string NameOz { get; set; }
    public string NameRu { get; set; }
    public long RegionId { get; set; }
    public Region Region { get; set; }
}
