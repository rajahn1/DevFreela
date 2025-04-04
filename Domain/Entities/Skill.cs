namespace Domain.Entities;

public class Skill(string description) : BaseEntity
{
    public string Description { get; private set; } = description;

    public void Update(int id, string description)
    {
        Id = id;
        Description = description;
    }
}