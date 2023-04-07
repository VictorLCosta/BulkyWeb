using Bogus;

using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Persistence;

public class ApplicationDbContextInitialiser
{
    private readonly ApplicationDbContext _context;

    public ApplicationDbContextInitialiser(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task InitialiseAsync()
    {
        try
        {
            await _context.Database.MigrateAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task SeedAsync()
    {
        if(!await _context.Categories.AnyAsync())
        {
            var categories = new Faker<Category>()
                .RuleFor(x => x.Name, f => f.Commerce.Categories(1).FirstOrDefault())
                .RuleFor(x => x.DisplayOrder, f => f.Random.Int(1, 20))
                .Generate(20);

            await _context.Categories.AddRangeAsync(categories);
        }
    }

}
