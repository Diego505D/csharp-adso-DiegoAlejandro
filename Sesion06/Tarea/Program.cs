using Tarea;

ProcesadorPagos procesador = new();

IMetodoPago efectivo = new PagoEfectivo();

IMetodoPago tarjeta = new PagoTarjeta("1234567890123456");

IMetodoPago billetera = new PagoBilletera();

Console.WriteLine("===== SISTEMA DE PAGOS =====");


Console.WriteLine("\n===== COBROS =====");

procesador.Cobrar(efectivo, 100000m);

procesador.Cobrar(tarjeta, 200000m);

procesador.Cobrar(billetera, 150000m);


Console.WriteLine("\n===== PRUEBA DE VALIDACIÓN =====");

procesador.Cobrar(billetera, 2500000m);


Console.WriteLine("\n===== REEMBOLSOS =====");

procesador.Devolver(efectivo, 100000m);

procesador.Devolver(tarjeta, 200000m);

procesador.Devolver(billetera, 150000m);