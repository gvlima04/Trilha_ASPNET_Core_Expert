using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;

namespace MVC_Demo.Controllers;
[Route("")]
[Route("Home")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [Route("")]
    [Route("home")]
    [Route("home/{id:int}/{category}")]
    public IActionResult Index(int id, string category, string var)
    {
        // Apenas para teste das validações, vamos criar um Movie com dados inválidos.
        Movie movie = new Movie
        {
            Id = 10,
            Title = "Oi",
            ReleaseDate = DateTime.Now,
            Value = 10000,
            Rating = 10
        };

        // Vamos chamar a Action Privacy onde validaremos o objeto movie

        return RedirectToAction("Privacy", movie);
        // return View();
    }

    [Route("privacidade")]
    [Route("politica-de-privacidade")]
    public IActionResult Privacy(Movie movie)
    {
        if(!ModelState.IsValid){
            Console.WriteLine($"{ModelState.Count} error(s) found");
            foreach (var error in ModelState.Values.SelectMany(i => i.Errors))
            {
                Console.WriteLine($"Error: {error.ErrorMessage}");
            }

        }

        return View();
    }

    [Route("json")]
    public IActionResult MyJson()
    {
        return Json("[{'nome':'Guilherme','idade':27},{'nome':'Renata','idade': 31}]");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [Route("error")]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
