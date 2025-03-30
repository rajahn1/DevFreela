namespace Domain.Entities;

public class Product: BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    
    public List<Category> Categories { get; set; }
}