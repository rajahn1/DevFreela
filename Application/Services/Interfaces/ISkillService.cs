using Application.InputModels.Skill;
using Application.ViewModels.Skill;
namespace Application.Services.Interfaces;

public interface ISkillService
{
    public List<SkillViewModel> GetSkills();
    public SkillDetailsViewModel GetSkillById(int id);
    public void Delete(int id);
    public void Update(UpdateSkillInputModel model);
    public int Create(CreateSkillInputModel model);
}