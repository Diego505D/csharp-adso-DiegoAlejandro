using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

bool esFuerte;

do
{
    Console.Write("Contraseña: ");
    string contraseña = Console.ReadLine() ?? "";

    esFuerte = EvaluarContraseña(contraseña);

    Console.WriteLine();
} while (!esFuerte);

Console.WriteLine("Contraseña aceptada.");

static bool EvaluarContraseña(string contraseña)
{
    bool tieneMayuscula = false;
    bool tieneMinuscula = false;
    bool tieneNumero = false;
    bool tieneEspecial = false;

    foreach (char caracter in contraseña)
    {
        if (char.IsUpper(caracter))
        {
            tieneMayuscula = true;
        }
        else if (char.IsLower(caracter))
        {
            tieneMinuscula = true;
        }
        else if (char.IsDigit(caracter))
        {
            tieneNumero = true;
        }
        else if (!char.IsWhiteSpace(caracter))
        {
            tieneEspecial = true;
        }
    }

    bool[] resultados =
    {
        contraseña.Length >= 8,
        tieneMayuscula,
        tieneMinuscula,
        tieneNumero,
        tieneEspecial,
        !contraseña.Any(char.IsWhiteSpace)
    };

    string[] reglas =
    {
        "Mínimo 8 caracteres",
        "Una mayúscula",
        "Una minúscula",
        "Un número",
        "Un carácter especial",
        "Sin espacios"
    };

    int reglasCumplidas = 0;

    for (int i = 0; i < resultados.Length; i++)
    {
        string simbolo = resultados[i] ? "✔" : "✘";
        Console.WriteLine($"{simbolo} {reglas[i]}");

        if (resultados[i])
        {
            reglasCumplidas++;
        }
    }

    string nivel;

    if (reglasCumplidas == 6)
    {
        nivel = "Fuerte";
    }
    else if (reglasCumplidas >= 4)
    {
        nivel = "Media";
    }
    else
    {
        nivel = "Débil";
    }

    Console.WriteLine($"Nivel: {nivel} ({reglasCumplidas}/6)");

    return reglasCumplidas == 6;
}
