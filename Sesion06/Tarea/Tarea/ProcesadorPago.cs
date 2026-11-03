using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    public class ProcesadorPagos
    {
        public void Cobrar(MetodoClase metodo, decimal monto)
        {
            if (!metodo.Validar(monto))
            {
                Console.WriteLine("El pago no es valido.");
                return;
            }

            decimal comision = metodo.CalcularComision(monto);
            decimal total = monto + comision;

            Console.WriteLine("\n--- COBRO REALIZADO ---");
            Console.WriteLine($"Metodo: {metodo.Nombre}");
            Console.WriteLine($"Monto: ${monto:N0}");
            Console.WriteLine($"Comision: ${comision:N0}");
            Console.WriteLine($"Total: ${total:N0}");
        }

        public void Devolver(MetodoClase metodo, decimal monto)
        {
            if (metodo is Rembolsable reembolsable)
            {
                decimal valorDevuelto =
                    reembolsable.Reembolsar(monto);

                Console.WriteLine("\n--- REEMBOLSO REALIZADO ---");
                Console.WriteLine($"Metodo: {metodo.Nombre}");
                Console.WriteLine($"Valor devuelto: ${valorDevuelto:N0}");
            }
            else
            {
                Console.WriteLine(
                    $"El metodo {metodo.Nombre} no permite reembolsos."
                );
            }
        }
    }
}
