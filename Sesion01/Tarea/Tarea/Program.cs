using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int segundos = 3725;

            // Calcular las horas
            // int horas = segundos / 3600;

            // Obtener los segundos que sobran después de

            // Calcular los segundos restantes
            //int segundosRestantes = resto % 60;

            //Console.WriteLine(horas + " horas, " + minutos + " minutos, " + segundosRestantes + " segundos.");

            //int temperaturaEnCelsius = 25;
            //double temperaturaEnFahrenheit = (temperaturaEnCelsius * 9/5) + 32;
            //Console.WriteLine("Temperatura en Celsius: " + temperaturaEnCelsius);
            //Console.WriteLine("Temperatura en Fahrenheit: " + temperaturaEnFahrenheit);

            Console.WriteLine("Digite tres notas de un estudiante:");

            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 1: " + nota1);
            Console.WriteLine("Nota 2: " + nota2);
            Console.WriteLine("Nota 3: " + nota3);

            double promedio = (nota1 + nota2 + nota3) / 3.0;

            Console.WriteLine("Promedio: " + promedio.ToString("F1"));

        }
    }
}
