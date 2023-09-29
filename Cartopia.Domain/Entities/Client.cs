using Cartopia.Domain.Commons;

namespace Cartopia.Domain.Entities;

public class Client : Auditable
{
    public string Fullname { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
}