using Cartopia.Domain.Commons;

namespace Cartopia.Domain.Entities;

public class Region : Auditable
{
    public string Name_Uz { get; set; }
    public string Name_RU { get; set; }
    public string Name_Eng { get; set; }
}