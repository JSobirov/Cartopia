namespace Cartopia.Domain.Entities;

public class Basket
{
    public long ClientId { get; set; }
    public Client Client { get; set; }
    
    public List<Product> Products { get; set; }
    public long Amount { get; set; }
}