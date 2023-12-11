// Controllers/CategoryController.cs
using Ecommerce.Data;
using Ecommerce.Models;
using Ecommerce.Models.CategoryModels;
using Microsoft.AspNetCore.Mvc;


public class CategoryController : Controller
{
    private readonly AppDbContext _context;

    public CategoryController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var categories = _context.Categories.ToList();
        return View(categories);
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Category category)
    {
        var addCommand = new AddCommand(_context, category);
        addCommand.Execute();
        return RedirectToAction("Index");
    }

    public IActionResult Update(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var category = _context.Categories.Find(id);

        if (category == null)
        {
            return NotFound();
        }

        return View(category);
    }

    [HttpPost]
    public IActionResult Update(int id, Category category)
    {
        if (id != category.Id)
        {
            return NotFound();
        }

        var updateCommand = new UpdateCommand(_context, category);
        updateCommand.Execute();

        return RedirectToAction("Index");
    }

    public IActionResult Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var category = _context.Categories.Find(id);

        if (category == null)
        {
            return NotFound();
        }

        return View(category);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        var category = _context.Categories.Find(id);

        if (category == null)
        {
            return NotFound();
        }

        var deleteCommand = new DeleteCommand(_context, category);
        deleteCommand.Execute();

        return RedirectToAction("Index");
    }
}
