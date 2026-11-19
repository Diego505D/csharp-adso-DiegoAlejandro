namespace Tarea
{
    public class PagoBilletera : IMetodoPago, IReembolsable
    {
        public string Nombre => "Billetera digital";

        public decimal CalcularComision(decimal monto)
        {
            return monto * 0.01m;
        }

        public bool Validar(decimal monto)
        {
            return monto > 0 && monto <= 2_000_000m;
        }

        public void Reembolsar(decimal monto)
        {
            Console.WriteLine($"Reembolso de ${monto:N0} realizado a la billetera.");
        }
    }
}