using Application.InputModels.User;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(IUserService userService) : ControllerBase
{
  private readonly IUserService _userService = userService;

  [HttpGet]
  public IActionResult Get(string query)
  {
    var users = _userService.GetAll();
    return Ok(users);
  }

  [HttpGet("{id}")]
  public IActionResult GetById(int id)
  {
    var user = _userService.GetUserById(id);
    return Ok(user);
  }

  [HttpPost]
  public IActionResult Post([FromBody] NewUserInputModel model)
  {
    var id = _userService.Create(model);
    return CreatedAtAction(nameof(GetById), new { id = id }, model);
  }

  [HttpPut]
  public IActionResult Put([FromBody] UpdateUserInputModel model)
  {
    _userService.Update(model);
    return Ok(model.Id);
  }

  [HttpDelete("{id}")]
  public IActionResult Delete(int id)
  {
    _userService.Delete(id);
    return NoContent();
  }
}
