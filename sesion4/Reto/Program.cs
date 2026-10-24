
Dictionary<string, List<double>> notas = new(StringComparer.OrdinalIgnoreCase);

Console.WriteLine("==============================");
Console.WriteLine("       GESTOR DE NOTAS");
Console.WriteLine("==============================");

int opcion;

do
{
    Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
    Console.WriteLine("1. Registrar aprendiz");
    Console.WriteLine("2. Agregar nota");
    Console.WriteLine("3. Listar aprendices");
    Console.WriteLine("4. Ranking");
    Console.WriteLine("5. Mejor aprendiz y aprobados");
    Console.WriteLine("6. Eliminar aprendiz");
    Console.WriteLine("7. Salir");

    Console.Write("Seleccione una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Ingrese un número válido.");
        opcion = 0;
        continue;
    }

    switch (opcion)
    {
        case 1:
            RegistrarAprendiz();
            break;

        case 2:
            AgregarNota();
            break;

        case 3:
            ListarAprendices();
            break;

        case 4:
            MostrarRanking();
            break;

        case 5:
            MostrarMejorYaprobados();
            break;

        case 6:
            EliminarAprendiz();
            break;

        case 7:
            Console.WriteLine("Hasta luego.");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

} while (opcion != 7);
void RegistrarAprendiz()
{
    Console.Write("Nombre del aprendiz: ");
    string nombre = Console.ReadLine()?.Trim() ?? "";

    if (string.IsNullOrWhiteSpace(nombre))
    {
        Console.WriteLine("El nombre no puede estar vacío.");
        return;
    }

    if (notas.ContainsKey(nombre))
    {
        Console.WriteLine("El aprendiz ya está registrado.");
        return;
    }

    notas.Add(nombre, new List<double>());

    Console.WriteLine("Aprendiz registrado correctamente.");
}
void AgregarNota()
{
    Console.Write("Nombre del aprendiz: ");
    string nombre = Console.ReadLine()?.Trim() ?? "";

    if (!notas.ContainsKey(nombre))
    {
        Console.WriteLine("El aprendiz no existe.");
        return;
    }

    Console.Write("Ingrese la nota (0 a 5): ");

    if (!double.TryParse(Console.ReadLine(), out double nota)
        || nota < 0 || nota > 5)
    {
        Console.WriteLine("La nota debe estar entre 0 y 5.");
        return;
    }

    notas[nombre].Add(nota);

    Console.WriteLine("Nota agregada correctamente.");
}
void ListarAprendices()
{
    if (notas.Count == 0)
    {
        Console.WriteLine("No hay aprendices registrados.");
        return;
    }

    foreach (var aprendiz in notas)
    {
        string nombre = aprendiz.Key;
        List<double> listaNotas = aprendiz.Value;

        double promedio = listaNotas.Count > 0
            ? listaNotas.Average()
            : 0;

        string juicio = listaNotas.Count > 0 && promedio >= 3
            ? "A"
            : "D";

        Console.WriteLine(
            $"{nombre,-15} {listaNotas.Count} notas · " +
            $"Promedio {promedio:F1} · Juicio {juicio}");
    }
}
void MostrarRanking()
{
    var ranking = notas
        .Where(a => a.Value.Count > 0)
        .OrderByDescending(a => a.Value.Average())
        .ToList();

    if (ranking.Count == 0)
    {
        Console.WriteLine("No hay aprendices con notas.");
        return;
    }

    Console.WriteLine("\n--- RANKING ---");

    foreach (var aprendiz in ranking)
    {
        Console.WriteLine(
            $"{aprendiz.Key,-15} " +
            $"Promedio {aprendiz.Value.Average():F1}");
    }
}
void MostrarMejorYaprobados()
{
    var evaluados = notas
        .Where(a => a.Value.Count > 0)
        .Select(a => new
        {
            Nombre = a.Key,
            Promedio = a.Value.Average()
        })
        .ToList();

    if (evaluados.Count == 0)
    {
        Console.WriteLine("Todavía no hay notas registradas.");
        return;
    }

    var mejor = evaluados
        .OrderByDescending(a => a.Promedio)
        .First();

    int aprobados = evaluados.Count(a => a.Promedio >= 3);

    Console.WriteLine(
        $"Mejor aprendiz: {mejor.Nombre} " +
        $"con promedio {mejor.Promedio:F1}");

    Console.WriteLine($"Cantidad de aprobados: {aprobados}");
}
void EliminarAprendiz()
{
    Console.Write("Nombre del aprendiz que desea eliminar: ");
    string nombre = Console.ReadLine()?.Trim() ?? "";

    if (notas.Remove(nombre))
    {
        Console.WriteLine("Aprendiz eliminado correctamente.");
    }
    else
    {
        Console.WriteLine("El aprendiz no existe.");
    }
}
