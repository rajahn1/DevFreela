namespace Domain.Entities;

public class Skill(string description) : BaseEntity
{
    public string Description { get; private set; } = description;
}