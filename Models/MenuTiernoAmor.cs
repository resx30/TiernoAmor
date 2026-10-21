namespace TiernoAmor.Models;

public static class MenuTiernoAmor
{
    public static readonly List<Producto> Productos = new()
    {
        new() { Id = 1, Nombre = "Café americano", Categoria = "Bebidas calientes", Descripcion = "Café de origen antioqueño, intenso y suave.", PrecioBase = 5000 },
        new() { Id = 2, Nombre = "Capuchino", Categoria = "Bebidas calientes", Descripcion = "Espresso con leche vaporizada y espuma cremosa.", PrecioBase = 7500 },
        new() { Id = 3, Nombre = "Chocolate caliente", Categoria = "Bebidas calientes", Descripcion = "Chocolate espeso con un toque de canela.", PrecioBase = 7000 },
        new() { Id = 4, Nombre = "Frappé de café", Categoria = "Bebidas frías", Descripcion = "Café helado batido con crema.", PrecioBase = 9500 },
        new() { Id = 5, Nombre = "Croissant", Categoria = "Panadería", Descripcion = "Hojaldrado y horneado cada mañana.", PrecioBase = 6000 },
        new() { Id = 6, Nombre = "Torta de zanahoria", Categoria = "Postres", Descripcion = "Porción con crema de queso.", PrecioBase = 8500 },
    };
}