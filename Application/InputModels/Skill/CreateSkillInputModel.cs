namespace Application.InputModels.Skill;

public class CreateSkillInputModel(string description, int id)
{
    public int Id { get; set; }
    public string Description { get; set; }
}
