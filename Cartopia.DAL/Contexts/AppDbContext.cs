using Cartopia.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cartopia.DAL.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<Basket> Baskets { get; set; }
    public DbSet<Credit> Credits { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}