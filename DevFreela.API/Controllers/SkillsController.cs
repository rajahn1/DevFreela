using Application.InputModels.Skill;
using Application.Services.Implementations;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SkillsController(SkillService skillService) : Controller
{
    private readonly SkillService  _skillService = skillService;
    
    [HttpGet]
    public IActionResult Get(string query)
    {
        var skills = _skillService.GetAll();
        return Ok(skills);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var skill = _skillService.GetSkillById(id);
        return Ok(skill);
    }

    [HttpPost]
    public IActionResult Post([FromBody] CreateSkillInputModel model)
    {
        var id = _skillService.Create(model);
        return CreatedAtAction(nameof(GetById), new { id = id }, model);
    }

    [HttpPut]
    public IActionResult Put([FromBody] UpdateSkillInputModel model)
    {
        _skillService.Update(model);
        return Ok(model.Id);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _skillService.Delete(id);
        return NoContent();
    }
}