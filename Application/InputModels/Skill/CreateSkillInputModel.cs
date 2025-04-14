namespace Application.InputModels.Skill;

public class CreateSkillInputModel(string description)
{
    public string Description { get; set; } = description;
}
