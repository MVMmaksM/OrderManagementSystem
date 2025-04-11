namespace CatalogService.Domain.Entities;

/// <summary>
/// класс сущности продукта
/// </summary>
public class Product : BaseEntity<Guid>
{
    public string Name { get; set; } 
    public string Description { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public DateTime CreatedDateUtc { get; set; }
    public DateTime UpdatedDateUtc { get; set; }
}