using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Ingrese su usuario");
            string usuario = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Ingrese su contraseña");
            string contraseña = Console.ReadLine().ToLower().Trim();




            if (usuario == "admin" && contraseña == "12345")
            {
                Console.WriteLine("Bienvenido a el sena");
                Console.WriteLine("Calculadora con switch");
                Console.WriteLine("Valor para a");
                string entrada = Console.ReadLine().Trim();
                int a = Convert.ToInt32(entrada);
                Console.WriteLine("Valor para b");
                float b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite la opcion deseada");
                Console.WriteLine("1. SUMAR");
                Console.WriteLine("2. RESTAR");
                Console.WriteLine("3. MULTIPLICAR");
                Console.WriteLine("4. DIVIDIR");
                Console.WriteLine("5. NOTAS");
                int opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine($"la suma de {a} + {b} es {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"la resta de {a} - {b} es {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"la multiplicacion de {a} * {b} es {a * b}");
                        break;
                    case 4:
                        if (b== 0)
                            Console.WriteLine("No se puede dividir entre 0");
                        else
                            Console.WriteLine($"la division de {a} /  {b} es {a / b}");


                        break;
                    case 5:
                        double nota = Convert.ToDouble(Console.ReadLine());
                        if (nota < 0 || nota > 5) 
                            Console.WriteLine("la nota debe de ser entre 0 y 5  ");
                        else
                        {
                            if (nota <= 3.0)
                                Console.WriteLine("deficiente");
                            else if (nota < 4)
                                Console.WriteLine("SOBRESALIENTE");
                            else if (nota < 4.5)
                                Console.WriteLine("EXCELENTE");
                            else
                                Console.WriteLine("SUPER EXCELENTE");
                           


                        }
                        break;
                    default:
                        Console.WriteLine("eleccion incorrecta");
                        break;

                }



                 


            }
            else
            {
                Console.WriteLine("ERROR AL INGRESAr");
            }

        }
    }
}
