using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Mission06_Larson.Models;

namespace Mission06_Larson.Controllers;

public class HomeController : Controller
{
    private MovieFileContext _context;

    public HomeController(MovieFileContext context) // Constructor
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View();
    }
    
    // About page route
    public IActionResult About()
    {
        return View("GetToKnowJoel");
    }
    
    // Movie form route
    public IActionResult MovieFile()
    {
        ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();
        
        return View(new Movie());
    }
    
    // Save movie form to the database route
    [HttpPost]
    public IActionResult MovieFile(Movie movie)
    {
        if (ModelState.IsValid)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            
            return View("Confirmation", movie);
        }
        else
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            
            return View(movie);
        }

    }

    public IActionResult MovieList()
    {
        var movies = _context.Movies
            .Include(x => x.Category)
            .OrderBy(x => x.Title)
            .ToList();
        
        return View(movies);
    }

    [HttpGet]
    public IActionResult Edit(int filmId)
    {
        var record = _context.Movies
            .Single(x => x.MovieID == filmId);
        
        ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();
        
        return View("MovieFile", record);
    }

    [HttpPost]
    public IActionResult Edit(Movie updateRecord)
    {
        _context.Update(updateRecord);
        _context.SaveChanges();

        return RedirectToAction("MovieList");
    }

    public IActionResult Delete(int filmId)
    {
        var recordToDelete = _context.Movies
            .Single(x => x.MovieID == filmId);
        
        return View(recordToDelete);
    }
    
    [HttpPost]
    public IActionResult Delete(Movie recordToDelete)
    {
        _context.Movies.Remove(recordToDelete);
        _context.SaveChanges();
        
        return RedirectToAction("MovieList");
    }
    
}