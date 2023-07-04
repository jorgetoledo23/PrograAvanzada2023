using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebInacap.Models;

namespace WebInacap.Controllers
{
    public class CarreraController : Controller
    {
        private readonly AppDbContext _context;
        public CarreraController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult CarreraIndex()
        {
            var Carreras = _context.tblCarreras.ToList();
            return View(Carreras);
        }

        public RedirectToActionResult addCarrera([FromForm] string Name, [FromForm] string Duracion)
        {
            if (Name == null || Duracion == null)
            {
                TempData["Error"] = "Error al agregar una Carrera";
                return RedirectToAction(nameof(CarreraIndex));
            }

            Carrera C = new Carrera()
            {
                Name = Name,
                Duracion = Duracion
            };

            _context.Add(C);
            _context.SaveChanges();
            return RedirectToAction(nameof(CarreraIndex));
        }
    }
}
