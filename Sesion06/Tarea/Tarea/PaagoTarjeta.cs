using System.Linq;
using Tarea;

public class PagoTarjeta : MetodoClase, Rembolsable
{
    public string Nombre => "Tarjeta";

    public string NumeroTarjeta { get; set; }

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
        return monto > 0 &&
               NumeroTarjeta.Length == 16 &&
               NumeroTarjeta.All(char.IsDigit);
    }

    public decimal Reembolsar(decimal monto)
    {
        return monto;
    }
}