using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class EcommerceDbContext: DbContext
{
    DbSet<Product> Products { get; set; }
    DbSet<Category> Categories { get; set; }
}