using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using inventariosmvc.Models;

namespace inventariosmvc.Controllers;

public class ProductosController : Controller
{
    private readonly InventariosContext _context;

    public ProductosController(InventariosContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var productos = await (
            from p in _context.Productos
            join m in _context.Marcas on p.IdMarca equals m.Id into marcas
            from m in marcas.DefaultIfEmpty()
            select new ProductoListado
            {
                Descripcion = p.Descripcion,
                Marca = m.Nombre ?? "Sin marca",
                Precio = p.Precio,
                Existencia = p.Existencia,
                FechaRegistro = p.FechaRegistro
            }).ToListAsync();

        return View(productos);
    }
}