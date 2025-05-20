using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers;

public class AccountController : Controller
{
    [Route("Login")]
    public IActionResult Login()
    {
        return View();
    }

    [Route("Register")]
    public IActionResult Register()
    {
        return View();
    }
}
