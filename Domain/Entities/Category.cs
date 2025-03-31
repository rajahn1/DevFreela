namespace Domain.Entities;

public class Category(string name) : BaseEntity
{
    public string Name { get; private set; } = name;
    public int IdUser { get;}
    public int IdCategory { get;}
}