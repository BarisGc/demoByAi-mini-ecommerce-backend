using DemoBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoBackend.Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
