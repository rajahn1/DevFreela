using Application.InputModels;
using Application.Services.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController(IProjectService projectService) : ControllerBase
{
    private readonly IProjectService _projectService = projectService;
    [HttpGet]
    public IActionResult Get(string query)
    {
        var projects = _projectService.GetAllProjects(query); 
        return Ok(projects);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var project = _projectService.GetProjectById(id);
        if (project == null)
        {
            return NotFound();
        }
        return Ok(project);
    }

    [HttpPost]
    public IActionResult Post([FromBody] NewProjectInputModel model)
    {
        if (model.Description.Length > 200)
        {
            return BadRequest();
        }
        var id = _projectService.Create(model);

        return CreatedAtAction(nameof(GetById), new { id = id }, model);
    }

    [HttpPut]
    public IActionResult Put([FromBody] UpdateProjectInputModel model)
    {
        if (model.Description.Length > 200)
        {
            return BadRequest();
        }
        _projectService.Update(model);
        return Ok(model.Id);
    }
    
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _projectService.Delete(id);
        return NoContent();
    }

    [HttpPut("{id}/start")]
    public IActionResult Start(int id)
    {
        _projectService.Start(id);
        return NoContent();
    }
    [HttpPut("{id}/finish")]
    public IActionResult Finish(int id)
    {
        _projectService.Finish(id);
        return NoContent();
    }

    [HttpPost("{id}/comments")]
    public IActionResult CreateComment(int id, CreateCommentInputModel model)
    {
        _projectService.CreateComment(model);
        return NoContent();
    } 
}