using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using onlineShop_website.Models;

namespace onlineShop_website.Controllers;

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

    [Route("AboutUs")]
    public IActionResult AboutUs()
    {
        return View();
    }

    [Route("ProductList")]
    public IActionResult ProductList()
    {
        return View();
    }

    [Route("ViewProduct")]
    public IActionResult Products()
    {
        return View();
    }

    [Route("ShopingList")]
    public IActionResult ShopingList()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
