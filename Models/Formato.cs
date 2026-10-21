using System.Globalization;

namespace TiernoAmor.Models;

public static class Formato
{
    // Devuelve $7.500 sin depender de la cultura del servidor
    public static string Moneda(decimal valor) =>
        "$" + valor.ToString("N0", CultureInfo.InvariantCulture).Replace(",", ".");
}