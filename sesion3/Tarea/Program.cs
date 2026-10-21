
using System;
using System.Text;

Console.WriteLine("=== GENERADOR DE USUARIOS ===");

Console.Write("Ingrese el nombre completo: ");
string nombre = Console.ReadLine() ?? "";

Console.Write("Ingrese el documento: ");
string documento = Console.ReadLine() ?? "";

string usuario = GenerarUsuario(nombre, documento);

Console.WriteLine("Usuario generado: " + usuario);


Console.WriteLine();
Console.WriteLine("=== ANALIZADOR DE FRASES ===");

Console.Write("Ingrese una frase: ");
string frase = Console.ReadLine() ?? "";

AnalizarFrase(frase);

static string GenerarUsuario(string nombreCompleto, string documento)
{
    string[] partes = nombreCompleto.Split(
        ' ',
        StringSplitOptions.RemoveEmptyEntries
    );

    if (partes.Length < 2 || documento.Length < 2)
    {
        return "Datos no validos";
    }

    string primerNombre = partes[0];
    string primerApellido;

    if (partes.Length == 4)
    {
        primerApellido = partes[2];
    }
    else if (partes.Length == 3)
    {
        primerApellido = partes[1];
    }
    else
    {
        primerApellido = partes[1];
    }

    string inicial = primerNombre.Substring(0, 1);
    string ultimosDigitos = documento.Substring(documento.Length - 2);

    string usuario = inicial + primerApellido + ultimosDigitos;

    usuario = usuario.ToLower();

    usuario = usuario
        .Replace("á", "a")
        .Replace("é", "e")
        .Replace("í", "i")
        .Replace("ó", "o")
        .Replace("ú", "u")
        .Replace("ü", "u")
        .Replace("ñ", "n");

    return usuario;
}



static void AnalizarFrase(string frase)
{
    string[] palabras = frase.Split(
        ' ',
        StringSplitOptions.RemoveEmptyEntries
    );

    Console.WriteLine("Cantidad de palabras: " + palabras.Length);

    StringBuilder fraseInvertida = new StringBuilder();

    for (int i = palabras.Length - 1; i >= 0; i--)
    {
        fraseInvertida.Append(palabras[i]);

        if (i > 0)
        {
            fraseInvertida.Append(" ");
        }
    }

    Console.WriteLine("Frase en orden inverso: " + fraseInvertida);
}
