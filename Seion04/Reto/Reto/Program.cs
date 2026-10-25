using System;
using System.Collections.Generic;
using System.Linq;

Dictionary<string, List<double>> notas = new(StringComparer.OrdinalIgnoreCase);


int opcion = 0;

do
{
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("\n===== GESTOR DE NOTAS =====");
    Console.WriteLine("1. Registrar aprendiz");
    Console.WriteLine("2. Agregar nota");
    Console.WriteLine("3. Listar todos los aprendices");
    Console.WriteLine("4. Mostrar ranking");
    Console.WriteLine("5. Mejor aprendiz y aprobados");
    Console.WriteLine("6. Eliminar aprendiz");
    Console.WriteLine("7. Salir");
    Console.Write("Seleccione una opción: ");
    opcion = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
    switch (opcion)
    {
        case 1:
            RegistarAprendiz(notas);
            break;
        case 2:
            AgregarNota(notas);
            break;
        case 3:
            listarAprendices(notas);
            break;
        case 4:
            MostrarRanking(notas);
            break;
        case 5:
            MostrarMejorYAprueban(notas);
            break;
        case 6:
            EliminarAprendiz(notas);
            break;
        case 7:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
            break;  
    }
} while (opcion != 7);

static void RegistarAprendiz(Dictionary<string, List<double>> notas)
{
    Console.Write("Ingrese el nombre del aprendiz: ");
    string nombre = Console.ReadLine();
    if (notas.ContainsKey(nombre))
    {
        Console.WriteLine("El aprendiz ya está registrado.");
    }
    else
    {
        notas.Add(nombre, new List<double>());
        Console.WriteLine($"Aprendiz {nombre} registrado exitosamente.");
    }
}

static void AgregarNota(Dictionary<string, List<double>> notas)
{
    Console.Write("Ingrese el nombre del aprendiz: ");
    string nombre = Console.ReadLine();
    if (notas.ContainsKey(nombre))
    {
        Console.Write("Ingrese la nota a agregar: ");
        string entrada = Console.ReadLine();

        if (double.TryParse(entrada, out double nota))
        {
            if (nota >= 0 && nota <= 5)
            {
                notas[nombre].Add(nota);
                Console.WriteLine($"Nota {nota} agregada al aprendiz {nombre}.");
            }
            else
            {
                Console.WriteLine("La nota debe estar entre 0 y 5.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Debes ingresar un número.");
        }
    }
    else
    {
        Console.WriteLine("El aprendiz no está registrado.");
    }
}   

static void listarAprendices(Dictionary<string, List<double>> notas)

{
    foreach (var aprendiz in notas)
    {
        string nombre = aprendiz.Key;
        List<double> listaNotas = aprendiz.Value;

        if (listaNotas.Count > 0)
        {
            double promedio = listaNotas.Average();

            string juicio;

            if (promedio >= 3)
            {
                juicio = "A";
            }
            else
            {
                juicio = "D";

            }
            Console.WriteLine($"{nombre} {listaNotas.Count} notas | promedio : {promedio:F1} | juicio : {juicio}");
        }
        else
        {
            Console.WriteLine($"{nombre,-15} 0 notas | Promedio: -- | Juicio: --");
        }
    }
    
}

static void MostrarRanking(Dictionary<string, List<double>> notas)
{
    Console.WriteLine("\n===== RANKING DE APRENDICES =====");

    var ranking = notas
        .Where(a => a.Value.Count > 0)
        .OrderByDescending(a => a.Value.Average());

    foreach (var aprendiz in ranking)
    {
        double promedio = aprendiz.Value.Average();

        Console.WriteLine($"{aprendiz.Key,-15} Promedio: {promedio:F1}");
    }
}

static void MostrarMejorYAprueban(Dictionary<string, List<double>> notas)
{
    Console.WriteLine("\n===== MEJOR APRENDIZ Y APROBADOS =====");

    var aprendicesConNotas = notas
        .Where(a => a.Value.Count > 0);

    if (!aprendicesConNotas.Any())
    {
        Console.WriteLine("No hay aprendices con notas registradas.");
        return;
    }

    var mejorAprendiz = aprendicesConNotas
        .OrderByDescending(a => a.Value.Average())
        .First();

    double promedio = mejorAprendiz.Value.Average();

    Console.WriteLine($"Mejor aprendiz: {mejorAprendiz.Key}");
    Console.WriteLine($"Promedio: {promedio:F1}");

    int aprobados = aprendicesConNotas
        .Count(a => a.Value.Average() >= 3.0);

    Console.WriteLine($"Cantidad de aprendices aprobados: {aprobados}");
}
static void EliminarAprendiz(Dictionary<string, List<double>> notas)
{
    Console.Write("Ingrese el nombre del aprendiz que desea eliminar: ");
    string nombre = Console.ReadLine();

    if (notas.ContainsKey(nombre))
    {
        notas.Remove(nombre);
        Console.WriteLine($"El aprendiz {nombre} fue eliminado correctamente.");
    }
    else
    {
        Console.WriteLine("El aprendiz no está registrado.");
    }
}