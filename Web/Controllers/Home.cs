using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace Web.Controllers;

[Route("")]
public sealed class Home : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View(nameof(Index));
    }

   
}
