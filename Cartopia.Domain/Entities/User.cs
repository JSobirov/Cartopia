using Cartopia.Domain.Commons;

namespace Cartopia.Domain.Entities;

public class User : Auditable
{
    public string Username { get; set; }
    public string Number { get; set; }
    public string Password { get; set; }
}   