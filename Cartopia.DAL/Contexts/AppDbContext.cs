using Microsoft.EntityFrameworkCore;

namespace Cartopia.DAL.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }


}
