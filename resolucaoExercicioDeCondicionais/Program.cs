// IF

int idade = 18;

if (idade >= 18) Console.WriteLine("Maior de idade.");

// IF - ELSE

double nota = 6;

if (nota >= 7) Console.WriteLine("Aprovado"); else Console.WriteLine("Reprovado");

// IF - ELSE IF - ELSE

if (nota >= 9) Console.WriteLine("Excelente");
else if (nota >= 7) Console.WriteLine("Aprovado");
else Console.WriteLine("Reprovado");

// Operador Ternário ?

Console.WriteLine(nota >= 7 ? "Aprovado" : "Reprovado");

// Switch

int dia = 3;

switch(dia)
{
    case 1:
        Console.WriteLine("Segunda");
        break;
    case 2:
        Console.WriteLine("Terça");
        break;
    case 3:
        Console.WriteLine("Quarta");
        break;
    default:
        Console.WriteLine("Dia inválido");
        break;
}

// SWITCH C# MODERNO

dia = 6;

string nomeDia = dia switch
{
    0 => "Domingo",
    1 => "Segunda",
    2 => "Terça",
    3 => "Quarta",
    4 => "Quinta",
    5 => "Sexta",
    6 => "Sábado",
    _ => "Inválido"
};

Console.WriteLine(nomeDia);

// CONDICIONAIS COM NULL

double? nota1 = null;
double notaFinal = nota1 ?? 0;

Console.WriteLine(notaFinal);

