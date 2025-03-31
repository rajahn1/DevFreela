using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get(string query)
    {
        return Ok(query);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok(id);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Project project)
    {
        return Ok();
    }

    [HttpPut]
    public IActionResult Put([FromBody] Project project)
    {
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public IActionResult Delete()
    {
        return Ok();
    }

    [HttpPut("{id}/start")]
    public IActionResult Start(int id)
    {
        return NoContent();
    }
    [HttpPut("{id}/finish")]
    public IActionResult Finish(int id)
    {
        return NoContent();
    }

    [HttpPost("{id}/comments")]
    public IActionResult CreateComment()
    {
        return Ok();  
    }
    
}