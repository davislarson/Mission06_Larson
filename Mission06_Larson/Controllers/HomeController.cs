using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
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

    public IActionResult About()
    {
        return View("GetToKnowJoel");
    }

    public IActionResult MovieFile()
    {
        return View();
    }

    [HttpPost]
    public IActionResult MovieFile(Movie movie)
    {
        _context.Movies.Add(movie);
        _context.SaveChanges();
        
        return View("Confirmation", movie);
    }
    
}