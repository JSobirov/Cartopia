using Cartopia.Domain.Commons;
using Cartopia.Domain.Enums;

namespace Cartopia.Domain.Entities;

public class Payment : Auditable
{
    public PaymentType Type { get; set; }

    public long BasketId { get; set; }
    public Basket Basket { get; set; } 
}
