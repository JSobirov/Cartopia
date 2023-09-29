using Cartopia.Domain.Commons;

namespace Cartopia.Domain.Entities;

public class Category : Auditable
{
    public string Name { get; set; }
}
