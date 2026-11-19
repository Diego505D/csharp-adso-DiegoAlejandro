namespace Tarea
{
    public class PagoTarjeta : IMetodoPago, IReembolsable
    {
        public string Nombre => "Tarjeta";

        public string NumeroTarjeta { get; }

        public PagoTarjeta(string numeroTarjeta)
        {
            NumeroTarjeta = numeroTarjeta;
        }

        public decimal CalcularComision(decimal monto)
        {
            return monto * 0.03m;
        }

        public bool Validar(decimal monto)
        {
            if (monto <= 0 || NumeroTarjeta.Length != 16)
            {
                return false;
            }

            foreach (char digito in NumeroTarjeta)
            {
                if (!char.IsDigit(digito))
                {
                    return false;
                }
            }

            return true;
        }

        public void Reembolsar(decimal monto)
        {
            Console.WriteLine($"Reembolso de ${monto:N0} realizado a la tarjeta.");
        }
    }
}