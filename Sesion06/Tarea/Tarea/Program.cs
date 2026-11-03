using System;
using Tarea;

public class Program
{
    public static void Main()
    {
        ProcesadorPagos procesador = new ProcesadorPagos();

        MetodoClase efectivo = new PagoEfectivo();

        MetodoClase tarjeta =
            new PagoTarjeta("1234567890123456");

        MetodoClase billetera = new PagoBilletera();

        // Cobros
        procesador.Cobrar(efectivo, 100000);

        procesador.Cobrar(tarjeta, 500000);

        procesador.Cobrar(billetera, 1500000);

        // Devoluciones
        procesador.Devolver(efectivo, 100000);

        procesador.Devolver(tarjeta, 500000);

        procesador.Devolver(billetera, 1500000);
    }
}
