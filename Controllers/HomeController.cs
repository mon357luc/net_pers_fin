using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using net_pers_fin.Models;

namespace net_pers_fin.Controllers;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) => _logger = logger;

    public IActionResult Index() => View();

    public IActionResult Welcome(string username = "Guest") => View();

    public IActionResult Privacy() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

    private string GetDebuggerDisplay() => ToString() ?? "No debugger display";
}
