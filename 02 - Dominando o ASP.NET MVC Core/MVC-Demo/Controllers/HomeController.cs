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
        return View();
    }

    [Route("privacidade")]
    [Route("politica-de-privacidade")]
    public IActionResult Privacy()
    {
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
