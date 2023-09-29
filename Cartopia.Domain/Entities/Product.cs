using Cartopia.Domain.Commons;

namespace Cartopia.Domain.Entities;

public class Product : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
 
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}