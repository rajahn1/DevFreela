using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
namespace EcommerceAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController(ILogger<ProductsController> logger) : ControllerBase
{
    private readonly ILogger<ProductsController> _logger = logger;
    
    /*
    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }
    */

    [HttpGet]
    public IActionResult Get(string query)
    {
        var products = new List<Product>();
        return Ok();
    }
}