using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithModel.Models;

namespace DojoSurveyWithModel.Controllers;

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
    // Crea metodo GET para poder llamar a la vista y sea renderizada
    [HttpGet("results")]
    public IActionResult Results()
    {
        return View();
    }

    // Se crea metodo POST, para el envío de los datos del formulario a la ruta results, mediante Modelo Survey que contiene las propiedades requeridas que serán enviadas desde el formulario de la request.
    [HttpPost("results")]
    public IActionResult Result(Survey survey)
    {
        var SurveyResponse = new
        {
            Name = survey.Name,
            Location = survey.Location,
            Language = survey.Language,
            Comment = survey.Comment
        };
        return View("Results", SurveyResponse);
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
