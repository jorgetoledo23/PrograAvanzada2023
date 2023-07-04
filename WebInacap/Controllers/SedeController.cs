using Microsoft.AspNetCore.Mvc;
using WebInacap.Models;

namespace WebInacap.Controllers
{
    public class SedeController : Controller
    {
        private readonly AppDbContext _context;

        public SedeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult SedeIndex()
        {
            var todasLasSedes = _context.tblSedes
                .ToList();
            return View(todasLasSedes);
        }

        public RedirectToActionResult addSede([FromForm] string NombreSede, 
            [FromForm] string Telefono, 
            [FromForm] string Correo, 
            [FromForm] string Direccion)
        {
            Sede sede = new Sede()
            {
                Nombre = NombreSede,
                Telefono = Telefono,
                Direccion = Direccion,
                Correo = Correo
            };
            _context.Add(sede);
            _context.SaveChanges();
            return RedirectToAction(nameof(SedeIndex));
        }
        
    }
}
