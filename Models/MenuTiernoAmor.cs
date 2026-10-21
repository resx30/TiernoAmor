namespace TiernoAmor.Models;

public static class MenuTiernoAmor
{
    public static readonly List<Producto> Productos = new()
    {
        new() { Id = 1, Nombre = "Café Americano", Categoria = "Bebida", Descripcion = "Suave y aromático, ideal para empezar el día.", PrecioBase = 4500 },
        new() { Id = 2, Nombre = "Café Latte", Categoria = "Bebida", Descripcion = "Espresso con leche cremosa.", PrecioBase = 6000 },
        new() { Id = 3, Nombre = "Café Mocha", Categoria = "Bebida", Descripcion = "Café, chocolate y leche vaporizada.", PrecioBase = 6500 },
        new() { Id = 4, Nombre = "Capuchino", Categoria = "Bebida", Descripcion = "Espresso, leche y espuma en partes iguales.", PrecioBase = 6000 },
        new() { Id = 5, Nombre = "Té de hierbas", Categoria = "Bebida", Descripcion = "Infusión relajante de hierbas naturales.", PrecioBase = 4000 },
        new() { Id = 6, Nombre = "Pastel de chocolate", Categoria = "Comida", Descripcion = "Porción individual, húmedo y con cobertura.", PrecioBase = 7000 },
        new() { Id = 7, Nombre = "Galletas caseras", Categoria = "Comida", Descripcion = "Horneadas en casa, crocantes por fuera.", PrecioBase = 3500 },
        new() { Id = 8, Nombre = "Sandwiches variados", Categoria = "Comida", Descripcion = "Jamón y queso o vegetariano.", PrecioBase = 8500 },
        new() { Id = 9, Nombre = "Ensaladas frescas", Categoria = "Comida", Descripcion = "Vegetales frescos de temporada.", PrecioBase = 9000 },
    };
}