using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _context;

    public CategoryController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var categoriesList = await _context.Categories.ToListAsync();

        return View(categoriesList);
    }

    public IActionResult Create()
    {
        ViewData["Title"] = "Create Category";

        return View();
    }

}
