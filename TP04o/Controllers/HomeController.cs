using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04o.Models;

namespace TP04o.Controllers;

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
    public IActionResult SelectPaquete()
    {
        ViewBag.Destinos = ORTWorld.ListaDestinos;
        ViewBag.Aereos = ORTWorld.ListaAereos;
        ViewBag.Hoteles = ORTWorld.ListaHoteles;
        ViewBag.Excursiones= ORTWorld.ListaExcursiones;
        return View();
    }
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion){

        
        return View();
    }
}
