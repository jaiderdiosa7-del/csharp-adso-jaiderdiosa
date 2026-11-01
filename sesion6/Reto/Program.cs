using Reto;

List<Empleado> nomina =
[
    new EmpleadoPlanta("Ana Gómez", "1001", 3_200_000m, 6),
    new EmpleadoPlanta("Luis Pérez", "1002", 2_800_000m, 2),
    new EmpleadoPorHoras("Marta Ruiz", "1003", 170, 18_000m),
    new EmpleadoPorHoras("Jorge Díaz", "1004", 120, 18_000m),
    new Contratista("Sofía León", "1005", 4_000_000m)
];

Console.WriteLine("===== NÓMINA DE EMPLEADOS =====");

foreach (Empleado empleado in nomina)
{
    Console.WriteLine(empleado);
}

// Total de la nómina
decimal totalNomina = nomina.Sum(e => e.CalcularSalario());

Console.WriteLine($"\nTotal de la nómina: ${totalNomina:N0}");

// Empleado con mayor pago
Empleado mayorPago = nomina.MaxBy(e => e.CalcularSalario())!;

Console.WriteLine("\nEmpleado con mayor pago:");
Console.WriteLine(mayorPago);

// Total por tipo de empleado
Console.WriteLine("\n===== TOTAL POR TIPO =====");

var grupos = nomina.GroupBy(e => e.Tipo);

foreach (var grupo in grupos)
{
    decimal totalTipo = grupo.Sum(e => e.CalcularSalario());

    Console.WriteLine($"{grupo.Key}: ${totalTipo:N0}");
}