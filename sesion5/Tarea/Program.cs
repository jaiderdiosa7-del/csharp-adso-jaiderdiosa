using Tarea;

CuentaBancaria cuenta1 = new("Jaider", "001", 100000m);
CuentaBancaria cuenta2 = new("Sonia", "002", 20000m);


bool depositoExitoso = cuenta1.Depositar(30000m);
Console.WriteLine($"Deposito realizado: {depositoExitoso}");
Console.WriteLine($"Saldo de Jaider: {cuenta1.Saldo}");


bool retiroExitoso = cuenta1.Retirar(200000m);

Console.WriteLine($"Retiro realizado: {retiroExitoso}");
Console.WriteLine($"Saldo de Jaider: {cuenta1.Saldo}");



bool transferenciaExitosa = cuenta1.Transferir(cuenta2,40000m);

Console.WriteLine($"Transfernecia realizada: {transferenciaExitosa}");
Console.WriteLine($"Saldo final de jaider: {cuenta1.Saldo}");
Console.WriteLine($"Saldo final de Sonia: {cuenta2.Saldo}");