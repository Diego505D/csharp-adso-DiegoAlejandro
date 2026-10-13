using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu nombre :");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad :");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu formacion :");
            string formacion = Console.ReadLine();
            Console.WriteLine("Ingresa el numero de tu ficha :");
            int ficha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa una frase que te guste:");
            string frase = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("+----------------------------------+");
            Console.WriteLine("|       MI TARJETA PERSONAL        |");
            Console.WriteLine("+----------------------------------+");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"| Nombre: {nombre} |");
            Console.WriteLine($"| Edad: {edad} |");
            Console.WriteLine($"| Formacion: {formacion} |");
            Console.WriteLine($"| Ficha: {ficha} |");
            Console.WriteLine($"| Frase: {frase} |");

            Console.WriteLine("+----------------------------------+");




        }

            
    }
}
