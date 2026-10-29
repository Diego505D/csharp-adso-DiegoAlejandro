
using Tarea;

CuentaBancaria cuenta1 = new CuentaBancaria("Diego", "1001", 100000m);
CuentaBancaria cuenta2 = new CuentaBancaria("Maria", "1002", 50000m);

Console.WriteLine("=== CUENTAS BANCARIAS ===");
Console.WriteLine($"Cuenta de {cuenta1.Titular}: ${cuenta1.Saldo}");
Console.WriteLine($"Cuenta de {cuenta2.Titular}: ${cuenta2.Saldo}");

// Prueba 1: depósito
Console.WriteLine("\n=== DEPOSITO ===");

bool deposito = cuenta1.depositar(30000m);

Console.WriteLine($"¿Deposito realizado? {deposito}");
Console.WriteLine($"Nuevo saldo de Diego: ${cuenta1.Saldo}");

// Prueba 2: retiro rechazado
Console.WriteLine("\n=== RETIRO RECHAZADO ===");

bool retiro = cuenta1.retirar(200000m);

Console.WriteLine($"¿Retiro realizado? {retiro}");
Console.WriteLine($"Saldo de Diego: ${cuenta1.Saldo}");

// Prueba 3: transferencia
Console.WriteLine("\n=== TRANSFERENCIA ===");

bool transferencia = cuenta1.transferir(cuenta2, 40000m);

Console.WriteLine($"¿Transferencia realizada? {transferencia}");
Console.WriteLine($"Saldo de Diego: ${cuenta1.Saldo}");
Console.WriteLine($"Saldo de Maria: ${cuenta2.Saldo}");
