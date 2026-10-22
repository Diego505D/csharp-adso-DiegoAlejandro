
using System;
using System.Text;

string nombreCompleto = "Ana Maria Gómez Pérez";

string[] partes = nombreCompleto.Split(' ');

string primerNombre = partes[0][0].ToString().ToLower();
string apellido = partes[2];

string documento = "1034567812";
string ultimosDigitos = documento.Substring(documento.Length - 2);
string usuario = partes + apellido.ToLower() + ultimosDigitos;

Console.WriteLine($"El nombre de usuario generado es: {usuario}");

Console.Write("Ingrese una frase: ");
string frase = Console.ReadLine() ?? "";


AnalizarFrase(frase);
static void AnalizarFrase(string frase)

{
    string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    int cantidadPalabras = palabras.Length;

    Console.WriteLine($"La frase contiene {cantidadPalabras} palabras.");

    StringBuilder fraseInvertida = new StringBuilder();

    for (int i = palabras.Length - 1; i >= 0; i--)
    {
        fraseInvertida.Append(palabras[i]);

        if (i > 0)
        {
            fraseInvertida.Append(" ");
        }
    }

    Console.WriteLine($"La frase invertida es: {fraseInvertida}");
}