using Reto;

List<Empleado> nomina =
[
    new EmpleadoPlanta("Ana Gómez", "1001", 3200000m, 6),
    new EmpleadoPlanta("Luis Pérez", "1002", 2800000m, 2),
    new EmpleadoPorHoras("Marta Ruiz", "1003", 170, 18000m),
    new EmpleadoPorHoras("Jorge Díaz", "1004", 120, 18000m),
    new Contratista("Sofía León", "1005", 4000000m)
];

Console.WriteLine("===== NÓMINA DE EMPLEADOS =====");

foreach (Empleado empleado in nomina)
{
    Console.WriteLine(empleado);
}


decimal totalNomina = nomina.Sum(e => e.CalcularSalario());

Console.WriteLine($"\nTotal de la nómina: ${totalNomina:N0}");


Empleado mayorPago = nomina.MaxBy(e => e.CalcularSalario())!;

Console.WriteLine("\nEmpleado con mayor pago:");
Console.WriteLine(mayorPago);


Console.WriteLine("\n===== TOTAL POR TIPO =====");

var grupos = nomina.GroupBy(e => e.Tipo);

foreach (var grupo in grupos)
{
    decimal totalTipo = grupo.Sum(e => e.CalcularSalario());

    Console.WriteLine($"{grupo.Key}: ${totalTipo:N0}");
}