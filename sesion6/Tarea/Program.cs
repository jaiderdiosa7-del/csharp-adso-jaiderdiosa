using Tarea;

ProcesadorPagos procesador = new();

IMetodoPago efectivo = new PagoEfectivo();

IMetodoPago tarjeta = new PagoTarjeta("1234567890123456");

IMetodoPago billetera = new PagoBilletera();

Console.WriteLine("===== SISTEMA DE PAGOS =====");


Console.WriteLine("\n===== COBROS =====");

procesador.Cobrar(efectivo, 100_000m);

procesador.Cobrar(tarjeta, 200_000m);

procesador.Cobrar(billetera, 150_000m);


Console.WriteLine("\n===== PRUEBA DE VALIDACIÓN =====");

procesador.Cobrar(billetera, 2_500_000m);


Console.WriteLine("\n===== REEMBOLSOS =====");

procesador.Devolver(efectivo, 100_000m);

procesador.Devolver(tarjeta, 200_000m);

procesador.Devolver(billetera, 150_000m);