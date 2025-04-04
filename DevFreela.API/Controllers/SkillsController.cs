using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers;

public class SkillsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}