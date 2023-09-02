using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SmartYbus_1.Models;

namespace SmartYbus_1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult HowItWork()
    {
        return View();
    }

    public IActionResult Services()
    {
        return View();
    }
     public IActionResult Contact()
     {
        return View();
     }
     public IActionResult RegisterSchool()
     {
        return View();
     }
    public IActionResult RegisterStudent()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }
     public IActionResult FAQ()
    {
        return View();
    }
     public IActionResult Blog()
    {
        return View();
    }

}
