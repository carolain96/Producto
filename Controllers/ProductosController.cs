using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Productos.Data;
using Productos.Models;

namespace Productos.Controllers
{
    public class ProductosController : Controller
    {
        private ProductosContext _context;
        public ProductosController(ProductosContext context)
        {
            _context = context;
        }

        public IActionResult Nuevo() {
            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(Producto p) {
            if (ModelState.IsValid) {
               
                _context.Add(p);
                _context.SaveChanges();
                
                return RedirectToAction("Lista");
            }
            
            return View(p);
        }

        public IActionResult Lista() {
            var Productos = _context.Productos.OrderBy(x => x.Nombre).ToList();
            return View(Productos);
        }
    }
}