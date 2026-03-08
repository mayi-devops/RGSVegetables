using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RGSVegetablesMVC.Models;

namespace RGSVegetablesMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Vegetables()
    {
        return View();
    }

    public IActionResult Clients()
    {
        return View();
    }

    public IActionResult Testimonials()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
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
