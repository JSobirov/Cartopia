namespace Cartopia.Domain.Entities;

public class Credit
{
    public long ClientId { get; set; }
    public Client Client { get; set; }

    public long BasketId { get; set; }
    public Basket Basket { get; set; }

    public decimal Amount { get; set; }
}