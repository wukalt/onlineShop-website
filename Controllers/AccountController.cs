using Microsoft.AspNetCore.Mvc;

namespace onlineShop_website.Controllers;

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
