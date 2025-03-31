namespace Domain.Entities;

public abstract class BaseEntity
{
    protected BaseEntity(){}
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}