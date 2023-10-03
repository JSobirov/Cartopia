using Cartopia.Domain.Commons;

namespace Cartopia.Domain.Entities;

public class Attachment : Auditable
{
    public string FilePath { get; set; }
    public string FileName { get; set; }
}
