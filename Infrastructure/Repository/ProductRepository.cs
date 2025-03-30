using Domain.Entities;
using Infrastructure.Data;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repository;

public class ProductRepository(ILogger<ProductRepository> logger,  EcommerceDbContext dbContext)
{
}