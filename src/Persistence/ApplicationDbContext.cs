using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
}
