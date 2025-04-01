using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KnapSoft.Models;

namespace KnapSoft.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult ProKoho()
    {
        return View();
    }

    public IActionResult Jak()
    {
        return View();
    }
    public IActionResult Kontakt()
    {
        return View();
    }
    public IActionResult Proc()
    {
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> Kontakt(string Name, string Email, string Message, [FromServices] EmailService emailService)
    {
        var subject = $"Zpráva z kontaktního formuláře – {Name}";
        var body = $"Jméno: {Name}\nEmail: {Email}\nZpráva:\n{Message}";

        await emailService.SendEmailAsync(Email, subject, body);

        TempData["Message"] = "Děkujeme za zprávu. Ozveme se co nejdříve.";
        return RedirectToAction("Kontakt");
    }
}
