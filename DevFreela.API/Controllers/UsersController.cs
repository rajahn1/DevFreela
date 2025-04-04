using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers;

public class UsersController : ControllerBase
{
    // GET
    public IActionResult Index()
    {
        return Ok();
    }
}