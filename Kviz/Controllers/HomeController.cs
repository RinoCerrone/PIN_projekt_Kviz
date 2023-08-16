using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Kviz.Models;
using System.Linq;
using System.Collections.Generic;
using Kviz.Data;


namespace Kviz.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var quizResults = _context.QuizResults
            .GroupBy(r => r.Title)
            .ToDictionary(g => g.Key, g => g.OrderByDescending(r => r.Score).Take(10).ToList());

        var quizResultTuples = quizResults
            .Select(kvp => (Title: kvp.Key, Results: kvp.Value))
            .ToList();

        return View(quizResultTuples);
    }



    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
