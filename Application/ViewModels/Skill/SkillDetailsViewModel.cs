namespace Application.ViewModels.Skill;

public class SkillDetailsViewModel(int id, string description)
{
    public int Id { get; set; } = id;
    public string Description { get; set; } = description;
}