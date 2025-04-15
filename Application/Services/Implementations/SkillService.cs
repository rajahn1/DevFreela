using Application.InputModels.Skill;
using Application.Services.Interfaces;
using Application.ViewModels.Skill;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementations;

public class SkillService(DevFreelaDbContext dbContext) : ISkillService
{
    public List<SkillViewModel> GetAll()
    {
        var skills = dbContext.Skills;
        return skills.Select(s => new SkillViewModel(s.Description, s.Id)).ToList();
    }

    public SkillDetailsViewModel GetSkillById(int id)
    {
        var skill = dbContext.Skills.FirstOrDefault(s => s.Id == id);
        if (skill == null) throw new KeyNotFoundException(); 
        return new SkillDetailsViewModel(skill.Id, skill.Description);
    }

    public void Delete(int id)
    {
        var skill = dbContext.Skills.FirstOrDefault(s => s.Id == id);
        if (skill == null) throw new KeyNotFoundException(); 
        dbContext.Skills.Remove(skill);
        dbContext.SaveChanges();
    }

    public void Update(UpdateSkillInputModel model)
    {
        var skill = dbContext.Skills.FirstOrDefault(s => s.Id == model.Id);
        if (skill == null) throw new KeyNotFoundException(); 
        skill.Update(model.Id, model.Description);
        dbContext.Update(skill);
        dbContext.SaveChanges();
    }
 
    public int Create(CreateSkillInputModel model)
    {
        Skill skill = new (model.Description);
        dbContext.Skills.Add(skill);
        dbContext.SaveChanges();
        return skill.Id;
    }
}