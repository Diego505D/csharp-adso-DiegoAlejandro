namespace Tarea
{
    public class ProcesadorPagos
    {
        public void Cobrar(IMetodoPago metodo, decimal monto)
        {
            Console.WriteLine($"\nMétodo de pago: {metodo.Nombre}");

            if (!metodo.Validar(monto))
            {
                Console.WriteLine("Pago rechazado. Datos inválidos.");
                return;
            }

            decimal comision = metodo.CalcularComision(monto);
            decimal total = monto + comision;

            Console.WriteLine($"Monto: ${monto:N0}");
            Console.WriteLine($"Comisión: ${comision:N0}");
            Console.WriteLine($"Total a pagar: ${total:N0}");
            Console.WriteLine("Pago realizado correctamente.");
        }

        public void Devolver(IMetodoPago metodo, decimal monto)
        {
            Console.WriteLine($"\nSolicitando reembolso con {metodo.Nombre}...");

            if (monto <= 0)
            {
                Console.WriteLine("El monto del reembolso debe ser mayor que cero.");
                return;
            }

            if (metodo is IReembolsable reembolsable)
            {
                reembolsable.Reembolsar(monto);
            }
            else
            {
                Console.WriteLine("Este método de pago no permite reembolsos.");
            }
        }
    }
}