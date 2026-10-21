using System.Text;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("=== VALIDADOR DE CONTRASEÑAS ===");

string[] reglas =
{
    "Mínimo 8 caracteres",
    "Una mayúscula",
    "Una minúscula",
    "Un número",
    "Un carácter especial",
    "Sin espacios"
};

string contraseña;
string nivel;
int puntos;

do
{
    Console.WriteLine();
    Console.Write("Ingrese una contraseña: ");
    contraseña = Console.ReadLine() ?? "";

    bool[] resultados = EvaluarContraseña(contraseña);

    puntos = 0;

    for (int i = 0; i < resultados.Length; i++)
    {
        if (resultados[i])
        {
            Console.WriteLine("✅ " + reglas[i]);
            puntos++;
        }
        else
        {
            Console.WriteLine("❌ " + reglas[i]);
        }
    }

    if (puntos == 6)
    {
        nivel = "Fuerte";
    }
    else if (puntos >= 4)
    {
        nivel = "Media";
    }
    else
    {
        nivel = "Débil";
    }

    Console.WriteLine("Nivel: " + nivel + " (" + puntos + "/6)");

} while (nivel != "Fuerte");

Console.WriteLine();
Console.WriteLine("¡Contraseña segura aceptada!");

static bool[] EvaluarContraseña(string contraseña)
{
    bool longitud = contraseña.Length >= 8;
    bool mayuscula = false;
    bool minuscula = false;
    bool numero = false;
    bool especial = false;
    bool sinEspacios = true;

    foreach (char caracter in contraseña)
    {
        if (char.IsUpper(caracter))
        {
            mayuscula = true;
        }

        if (char.IsLower(caracter))
        {
            minuscula = true;
        }

        if (char.IsDigit(caracter))
        {
            numero = true;
        }

        if (char.IsPunctuation(caracter) || char.IsSymbol(caracter))
        {
            especial = true;
        }

        if (caracter == ' ')
        {
            sinEspacios = false;
        }
    }

    return new bool[]
    {
        longitud,
        mayuscula,
        minuscula,
        numero,
        especial,
        sinEspacios
    };
}
