namespace Application.ViewModels.Skill;

public class SkillDetailsViewModel(string description, int id)
{
    public int Id { get; private set; } = id;
    public string Description { get; set; } = description;
}