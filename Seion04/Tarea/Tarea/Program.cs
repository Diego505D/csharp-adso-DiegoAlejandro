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


decimal totalVendido = ventas  .Select(v => v.Cantidad * v.PrecioUnitario).Sum();

Console.WriteLine($"Total vendido: {totalVendido:C}");

var promedioVenta = ventas .Average(v => v.Cantidad * v.PrecioUnitario);

Console.WriteLine($"Promedio por venta: {promedioVenta}");

var ventasPorCiudad = ventas.GroupBy(v => v.Ciudad)
.Select(g => new
    {
        Ciudad = g.Key,
        TotalVendido = g.Sum(v => v.Cantidad * v.PrecioUnitario)
    })
    .OrderByDescending(g => g.TotalVendido);

foreach (var ciudad in ventasPorCiudad)
{
    Console.WriteLine($"{ciudad.Ciudad}: {ciudad.TotalVendido}");
}

var topProductos = ventas.GroupBy(v => v.Producto).Select(g => new
    {
        Producto = g.Key,
        Ingresos = g.Sum(v => v.Cantidad * v.PrecioUnitario)
    })
    .OrderByDescending(g => g.Ingresos)
    .Take(3);

foreach (var producto in topProductos)
{
    Console.WriteLine($"{producto.Producto}: {producto.Ingresos:C0}");
}

var productoMasVendido = ventas
            .GroupBy(v => v.Producto)
            .Select(g => new { Producto = g.Key, Unidades = g.Sum(v => v.Cantidad) })
            .OrderByDescending(x => x.Unidades)
            .FirstOrDefault();
Console.WriteLine($"Producto más vendido: {productoMasVendido?.Producto} ({productoMasVendido?.Unidades} unidades)");


record Venta(string Producto, string Ciudad, int Cantidad, decimal PrecioUnitario);