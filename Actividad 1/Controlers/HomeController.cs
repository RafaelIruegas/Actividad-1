using Actividad_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad_1.Controlers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			MiPerfilViewModel vm = new();
			vm.nombre = "Rafael Alejandro Iruegas Rosales";
			return View(vm);
        }
        public IActionResult MiPerfil() { MiPerfilViewModel vm = new(); 
            vm.nombre = "Rafael Alejandro Iruegas Rosales";
            vm.edad = 21; 
            vm.numerodecontrol="201G0263";
            vm.Fecha = "01 / 15 / 2002";
            vm.Correo = "rafaeliruegas1099@gmail.com";
            return View(vm); }
    }
}
