namespace Domain.Entities;

public class Category(string name) : BaseEntity
{

    public string? Name { get; } = name;
    public int IdUser { get; set; }
    public int IdCategory { get; set; }
}