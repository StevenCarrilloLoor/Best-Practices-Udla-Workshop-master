
// ARCHIVO MODIFICADO - Agregar Factory Manager y método AddEscape

using Best_Practices.Infraestructure.Factories;
using Best_Practices.Infraestructure.Singletons;
using Best_Practices.Models;
using Best_Practices.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly VehicleFactoryManager _factoryManager; // NUEVO

        public HomeController(IVehicleRepository vehicleRepository, ILogger<HomeController> logger)
        {
            _vehicleRepository = vehicleRepository;
            _logger = logger;
            _factoryManager = new VehicleFactoryManager(); // NUEVO: Inicializar factory manager
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel();
            model.Vehicles = VehicleCollection.Instance.Vehicles;
            string error = Request.Query.ContainsKey("error") ? Request.Query["error"].ToString() : null;
            ViewBag.ErrorMessage = error;

            return View(model);
        }

        [HttpGet]
        public IActionResult AddMustang()
        {
            try
            {
                var vehicle = _factoryManager.CreateVehicle("Mustang"); // MODIFICADO: Usar factory manager
                _vehicleRepository.AddVehicle(vehicle);
                return Redirect("/");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al agregar Mustang");
                return Redirect($"/?error={ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult AddExplorer()
        {
            try
            {
                var vehicle = _factoryManager.CreateVehicle("Explorer"); // MODIFICADO: Usar factory manager
                _vehicleRepository.AddVehicle(vehicle);
                return Redirect("/");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al agregar Explorer");
                return Redirect($"/?error={ex.Message}");
            }
        }

        // NUEVO: Método para agregar Escape
        [HttpGet]
        public IActionResult AddEscape()
        {
            try
            {
                var vehicle = _factoryManager.CreateVehicle("Escape");
                _vehicleRepository.AddVehicle(vehicle);
                return Redirect("/");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al agregar Escape");
                return Redirect($"/?error={ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult StartEngine(string id)
        {
            try
            {
                var vehicle = _vehicleRepository.Find(id);
                vehicle.StartEngine();
                return Redirect("/");
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return Redirect($"/?error={ex.Message}");
            }
          
        }

        [HttpGet]
        public IActionResult AddGas(string id)
        {

            try
            {
                var vehicle = _vehicleRepository.Find(id);
                vehicle.AddGas();
                return Redirect("/");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return Redirect($"/?error={ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult StopEngine(string id)
        {
            try
            {
                var vehicle = _vehicleRepository.Find(id);
                vehicle.StopEngine();
                return Redirect("/");
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return Redirect($"/?error={ex.Message}");
            }
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
}