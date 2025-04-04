using Application.InputModels.Skill;
using Application.Services.Interfaces;
using Application.ViewModels.Skill;

namespace Application.Services.Implementations;

public class SkillService : ISkillService
{
    public List<SkillViewModel> GetSkills()
    {
        throw new NotImplementedException();
    }

    public SkillDetailsViewModel GetSkillById(int id)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(UpdateSkillInputModel model)
    {
        throw new NotImplementedException();
    }

    public int Create(CreateSkillInputModel model)
    {
        throw new NotImplementedException();
    }
}