using Application.InputModels.Skill;
using Application.Services.Interfaces;
using Application.ViewModels.Skill;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementations;

public class SkillService(DevFreelaDbContext dbContext) : ISkillService
{
    private readonly DevFreelaDbContext _dbContext =  dbContext;
    public List<SkillViewModel> GetAll()
    {
        var skills = _dbContext.Skills;
        return skills.Select(s => new SkillViewModel(s.Description, s.Id)).ToList();
    }

    public SkillDetailsViewModel GetSkillById(int id)
    {
        var skill = _dbContext.Skills.FirstOrDefault(s => s.Id == id);
        if (skill == null) throw new KeyNotFoundException(); 
        return new SkillDetailsViewModel(skill.Id, skill.Description);
    }

    public void Delete(int id)
    {
        var skill = _dbContext.Skills.FirstOrDefault(s => s.Id == id);
        if (skill == null) throw new KeyNotFoundException(); 
        _dbContext.Skills.Remove(skill);
    }

    public void Update(UpdateSkillInputModel model)
    {
        var skill = _dbContext.Skills.FirstOrDefault(s => s.Id == model.Id);
        if (skill == null) throw new KeyNotFoundException(); 
        skill.Update(model.Id, model.Description);
        _dbContext.Update(skill);
    }
 
    public int Create(CreateSkillInputModel model)
    {
        Skill skill = new (model.Description);
        _dbContext.Skills.Add(skill);
        _dbContext.SaveChanges();
        return skill.Id;
    }
}