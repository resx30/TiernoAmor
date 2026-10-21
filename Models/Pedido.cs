using System.ComponentModel.DataAnnotations;

namespace TiernoAmor.Models;

public class Pedido
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Dinos tu nombre")]
    [StringLength(50)]
    [Display(Name = "Nombre del cliente")]
    public string NombreCliente { get; set; } = "";

    [Required(ErrorMessage = "El correo es obligatorio")]
    [EmailAddress(ErrorMessage = "Correo no válido")]
    public string Correo { get; set; } = "";

    [Required(ErrorMessage = "Selecciona un producto")]
    [Display(Name = "Producto")]
    public int ProductoId { get; set; }

    [Required]
    [Display(Name = "Tamaño")]
    public string Tamano { get; set; } = "Mediano";

    [Range(1, 20, ErrorMessage = "Cantidad entre 1 y 20")]
    public int Cantidad { get; set; } = 1;

    [Display(Name = "¿Para llevar?")]
    public bool ParaLlevar { get; set; }

    [StringLength(120)]
    public string? Notas { get; set; }

    public string ProductoNombre { get; set; } = "";
    public decimal Descuento { get; set; }
    public decimal Total { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;
}