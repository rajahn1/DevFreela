using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers;

public class UserController : ControllerBase
{
    // GET
    public IActionResult Index()
    {
        return Ok();
    }
}