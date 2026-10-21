using System.Text;

MostrarTitulo("Mis Metodos");
Console.WriteLine(Sumar(5, 8));
Console.WriteLine(MensajeConNumeros(15,"este es el mensaje" ));
Console.WriteLine(EsPar(7));
//esta es un procedimiento 
static void MostrarTitulo(string mensaje)
{
    Console.WriteLine($"=== {mensaje.ToUpper()} ===");
}
// este es una funcion 
static int Sumar(int a, int b)
{
    return a + b;
}

static string MensajeConNumeros(int x,string dato)
{
    return $"{dato}, y su numero es {x}";
}

static bool EsPar(int numero)
{
    return numero % 2 == 0;
}
//sobrecargas y opcionales
static double Area(double lado) => lado * lado;
static double Area1(double ancho, double alto) => ancho * alto;
Area(4);
Area1(4, 3);

static void Saludar(string nombre = "invitado", string saludo = "Hola")
{
    Console.WriteLine($"{saludo},{nombre}!!");
}
Saludar("Jaider", "Bienvenido");
Saludar("Diosa");
Saludar();

static int Multiplicar(int a = 3, int b = 2)
{
    return a * b;
}
Console.WriteLine(Multiplicar(5, 3));
Console.WriteLine(Multiplicar(9));
Console.WriteLine(Multiplicar());

//Metodos Comodin
static decimal LeerEntero(string mensaje)
{
    Console.Write(mensaje);
    decimal valor;
    while(!decimal.TryParse(Console.ReadLine(), out valor))
    {
        Console.Write("Valor no valido, intenta de nuevo \nDigite un numero entero:  ");
    }
    return valor;
}
Console.WriteLine("Digite un numero entero: ");

//Arreglos y Cadenas
double[] notas = new double[5];//declara el arreglo
for (int i = 0; i < notas.Length; i++)
{
    Console.Write($"Nota {i + 1}:");
    double.TryParse(Console.ReadLine(), out notas[i]);//Llena el arreglo 
}
Console.WriteLine(string.Join(" | ", notas));//Muestra el arreglo

//Contar vocales en una frase 
static int ContarVocales(string textoo)
{
    int total = 0;
    foreach(char c in textoo.ToLower())
    {
        if ("aeiouáéíóú".Contains(c))
            total++;
    }
    return total;
}

Console.WriteLine(ContarVocales("Hola señora cucho "));

Console.WriteLine(char.IsDigit('7'));
Console.WriteLine(char.IsDigit('e'));

Console.WriteLine(char.IsUpper('A'));
Console.WriteLine(char.IsUpper('a'));

Console.WriteLine(char.IsLower('e'));
Console.WriteLine(char.IsLower('E'));

Console.WriteLine(char.IsWhiteSpace(' '));

//contar tipos de caracteres
string texto = "hola mundo 2026_04";
int digitos = 0, mayusculas = 0,minusculas = 0, espacios = 0,especiales = 0;
foreach(char c in texto)
{
    if (char.IsDigit(c)) digitos++;
    else if (char.IsUpper(c)) mayusculas++;
    else if (char.IsLower(c)) minusculas++;
    else if (char.IsWhiteSpace(c)) espacios++;
    else if (char.IsPunctuation(c) || char.IsSymbol(c)) especiales++;

}
Console.WriteLine($"Digitos: {digitos}");
Console.WriteLine($"Mayusculas: {mayusculas}");
Console.WriteLine($"Minusculas: {minusculas}");
Console.WriteLine($"Espacios en blanco: {espacios}");
Console.WriteLine($"Caracteres especiales: {especiales}");


//primera linea del archivo
static string Invertir(string texto)
{
    var sb = new StringBuilder();
    for (int i = texto.Length -1; i >= 0; i--) sb.Append(texto[i]);
    return sb.ToString();
}