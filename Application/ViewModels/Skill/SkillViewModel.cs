namespace Application.ViewModels.Skill;

public class SkillViewModel(string description, int id)
{
    public string Description { get; set; } = description;
    public int Id { get; private set; } = id;
}