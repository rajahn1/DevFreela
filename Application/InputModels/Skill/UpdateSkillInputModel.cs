namespace Application.InputModels.Skill;

public class UpdateSkillInputModel(string description, int id)
{
    public int Id { get; set; }
    public string Description { get; set; } = description;
}