using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using MvcMovie.Services;
using MvcMovie.Services.Interface;
using NuGet.DependencyResolver;

namespace MvcMovie.Controllers;

public class HelloController : Controller
{
  private readonly ILogger<HelloController> _logger;
  private readonly IMessageWriter _messageWriterService;

  public HelloController(ILogger<HelloController> logger, IMessageWriter messageWriterService)
  {
    _logger = logger;
    _messageWriterService = messageWriterService;
  }

  public IActionResult Index()
  {
    // ViewBag.message = "hihi";
    ViewData["message"] = "hihi";
    return View();
  }

  public IActionResult About()
  {
    ViewData["Message"] = "2255777";
    return View();
  }

  public IActionResult Welcome(string name, int numTimes = 1)
  {
    ViewData["Message"] = "Hello " + name;
    ViewData["NumTimes"] = numTimes;
    return View();
  }

  public string HelloDI()
  {
    _messageWriterService.Write("hi");
    return "ok";
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
