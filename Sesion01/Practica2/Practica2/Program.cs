using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valor = 1234567.891m;
            Console.WriteLine($"{valor:N2}");   // 1.234.567,89
            Console.WriteLine($"{valor:C0}");   // $ 1.234.568

            Console.Write("Escribe tu edad: ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                Console.WriteLine($"El próximo año tendrás {edad + 1} años.");
            }
            else
            {
                Console.WriteLine("Eso no es un número entero.");
            }
        }
    }
}
