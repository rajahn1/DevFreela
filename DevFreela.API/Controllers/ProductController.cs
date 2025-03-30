using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
namespace EcommerceAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    
    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        var products = new List<Product>();
        products.Add(new Product { Id = 1, Name = "Product 1", Description = "Product 1 description", Price = 28.30M }); 
        return products;
    }
}