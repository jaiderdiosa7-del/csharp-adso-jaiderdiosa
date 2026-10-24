
List<Venta> ventas =
[
    new("Portátil", "Medellín", 2, 2_800_000m),
    new("Mouse", "Bogotá", 10, 45_000m),
    new("Teclado", "Cali", 5, 120_000m),
    new("Monitor", "Medellín", 3, 750_000m),
    new("Mouse", "Medellín", 8, 45_000m),
    new("Portátil", "Bogotá", 1, 2_800_000m),
    new("Diadema", "Cali", 6, 180_000m),
    new("Monitor", "Bogotá", 2, 750_000m),
    new("Teclado", "Medellín", 4, 120_000m),
    new("Diadema", "Bogotá", 3, 180_000m),
    new("Portátil", "Cali", 2, 2_800_000m),
    new("Mouse", "Cali", 12, 45_000m)
];

Console.WriteLine("=== ANALIZADOR DE VENTAS ===");
Console.WriteLine("1. Total vendido");
Console.WriteLine("2. Promedio por venta");
Console.WriteLine("3. Ventas por ciudad");
Console.WriteLine("4. Top 3 productos por ingresos");
Console.WriteLine("5. Producto más vendido");
Console.WriteLine("0. Salir");
Console.Write("Seleccione una opción: ");

int.TryParse(Console.ReadLine(), out int opcion);

switch (opcion)
{
    case 1:
        MostrarTotal(ventas);
        break;

    case 2:
        MostrarPromedio(ventas);
        break;

    case 3:
        MostrarVentasPorCiudad(ventas);
        break;

    case 4:
        MostrarTopProductos(ventas);
        break;

    case 5:
        MostrarProductoMasVendido(ventas);
        break;

    case 0:
        Console.WriteLine("Programa finalizado.");
        break;

    default:
        Console.WriteLine("Opción no válida.");
        break;
}

void MostrarTotal(List<Venta> ventas)
{
    decimal total = ventas.Sum(v => v.Cantidad * v.PrecioUnitario);

    Console.WriteLine($"Total vendido: ${total:N0}");
}

void MostrarPromedio(List<Venta> ventas)
{
    decimal promedio = ventas.Average(v => v.Cantidad * v.PrecioUnitario);

    Console.WriteLine($"Promedio por venta registrada: ${promedio:N2}");
}

void MostrarVentasPorCiudad(List<Venta> ventas)
{
    var resultados = ventas
        .GroupBy(v => v.Ciudad)
        .Select(g => new
        {
            Ciudad = g.Key,
            Total = g.Sum(v => v.Cantidad * v.PrecioUnitario)
        })
        .OrderByDescending(v => v.Total);

    foreach (var venta in resultados)
    {
        Console.WriteLine($"{venta.Ciudad}: ${venta.Total:N0}");
    }
}

void MostrarTopProductos(List<Venta> ventas)
{
    var resultados = ventas
        .GroupBy(v => v.Producto)
        .Select(g => new
        {
            Producto = g.Key,
            Ingresos = g.Sum(v => v.Cantidad * v.PrecioUnitario)
        })
        .OrderByDescending(v => v.Ingresos)
        .Take(3);

    foreach (var producto in resultados)
    {
        Console.WriteLine($"{producto.Producto}: ${producto.Ingresos:N0}");
    }
}

void MostrarProductoMasVendido(List<Venta> ventas)
{
    var producto = ventas
        .GroupBy(v => v.Producto)
        .Select(g => new
        {
            Producto = g.Key,
            Unidades = g.Sum(v => v.Cantidad)
        })
        .OrderByDescending(v => v.Unidades)
        .First();

    Console.WriteLine(
        $"Producto más vendido: {producto.Producto} ({producto.Unidades} unidades)");
}

record Venta(string Producto, string Ciudad, int Cantidad, decimal PrecioUnitario);
