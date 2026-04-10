using Microsoft.AspNetCore.Mvc;
using Web.Views.Home.Models;

namespace Web.Controllers;
[Route("")]
public sealed class Home : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View(nameof(Index), new IndexViewModel(Notifications: []));
    }
}