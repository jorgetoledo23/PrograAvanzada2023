using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebInacap.Models;
using WebInacap.ViewModels;

namespace WebInacap.Controllers
{
    public class SedeCarreraController : Controller
    {
        private readonly AppDbContext _context;
        public SedeCarreraController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult SedeCarreraIndex()
        {
            var sedes = _context.tblSedes.ToList();
            var carreras = _context.tblCarreras.ToList();

            var carrerasSede = _context.tblSedeCarreras
                .Include(x=> x.Carrera)
                .Include(x=> x.Sede)
                .ToList();

            SedeCarreraViewModel sedeCarreraViewModel = new SedeCarreraViewModel()
            {
                Sedes = sedes,
                CarrerasSede = carrerasSede
            };

            ViewData["Carreras"] = new SelectList(carreras, "Id", "Name");
            ViewData["Sedes"] = new SelectList(sedes, "Id", "Nombre");


            return View(sedeCarreraViewModel);
        }

        public IActionResult addCarreraSede([FromForm] int CarreraId, 
            [FromForm] int SedeId)
        {
            var exists = _context.tblSedeCarreras
                .Where(x => x.CarreraId == CarreraId && x.SedeId == SedeId)
                .FirstOrDefault();

            if (exists != null) TempData["Info"] = "Error: Vinculo ya Existe";
            else
            {
                SedeCarrera sedeCarrera = new SedeCarrera()
                {
                    CarreraId = CarreraId,
                    SedeId = SedeId
                };
                _context.Add(sedeCarrera);
                _context.SaveChanges();
                TempData["Info"] = "Info: Vinculo Agregado";
            }
            return RedirectToAction(nameof(SedeCarreraIndex));

        }


        public RedirectToActionResult deleteSedeCarrera (int sedeId, int carreraId)
        {
            var sedecarrera = _context.tblSedeCarreras.FirstOrDefault(x => x.SedeId == sedeId && x.CarreraId == carreraId);
            if (sedecarrera != null)
            {
                _context.Remove(sedecarrera);
                _context.SaveChanges();
                TempData["Info"] = "Info: Vinculo Eliminado";
            }
            else
            {
                TempData["Info"] = "Error: No se pudo Eliminar";
            }
            return RedirectToAction(nameof(SedeCarreraIndex));
        }


    }
}
