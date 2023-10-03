using Cartopia.Domain.Enums;
using Cartopia.Domain.Commons;

namespace Cartopia.Domain.Entities;

public class Payment : Auditable
{
    public PaymentType Type { get; set; }

    public long BasketId { get; set; }
    public Basket Basket { get; set; } 
}