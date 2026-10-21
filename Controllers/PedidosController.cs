using Microsoft.AspNetCore.Mvc;
using TiernoAmor.Models;

namespace TiernoAmor.Controllers;

public class PedidosController : Controller
{
    private static readonly List<Pedido> _pedidos = new();

    // GET: /Pedidos
    public IActionResult Index() => View(_pedidos.OrderByDescending(p => p.Fecha).ToList());

    // GET: /Pedidos/Crear -> muestra el formulario vacío
    [HttpGet]
    public IActionResult Crear()
    {
        ViewBag.Productos = MenuTiernoAmor.Productos;
        return View(new Pedido());
    }

    // POST: /Pedidos/Crear -> valida y procesa
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Crear(Pedido pedido)
    {
        var producto = MenuTiernoAmor.Productos.FirstOrDefault(p => p.Id == pedido.ProductoId);
        if (producto == null)
            ModelState.AddModelError(nameof(pedido.ProductoId), "Producto no encontrado");

        if (!ModelState.IsValid)
        {
            ViewBag.Productos = MenuTiernoAmor.Productos;
            return View(pedido);
        }

        // Procesamiento en C#
        decimal factor = pedido.Tamano switch
        {
            "Pequeño" => 1m,
            "Mediano" => 1.25m,
            "Grande" => 1.5m,
            _ => 1m
        };
        decimal subtotal = producto!.PrecioBase * factor * pedido.Cantidad;
        pedido.Descuento = pedido.Cantidad >= 5 ? subtotal * 0.10m : 0m; // 10% desde 5 unidades
        pedido.Total = subtotal - pedido.Descuento;
        pedido.ProductoNombre = producto.Nombre;
        pedido.Id = _pedidos.Count + 1;
        pedido.Fecha = DateTime.Now;

        _pedidos.Add(pedido);
        TempData["Mensaje"] = $"¡Gracias {pedido.NombreCliente}! Tu pedido quedó en {pedido.Total:C0}.";
        return RedirectToAction(nameof(Index));
    }
}