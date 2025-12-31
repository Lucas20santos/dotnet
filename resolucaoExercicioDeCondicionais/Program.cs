// // IF

// int idade = 18;

// if (idade >= 18) Console.WriteLine("Maior de idade.");

// // IF - ELSE

// double nota = 6;

// if (nota >= 7) Console.WriteLine("Aprovado"); else Console.WriteLine("Reprovado");

// // IF - ELSE IF - ELSE

// if (nota >= 9) Console.WriteLine("Excelente");
// else if (nota >= 7) Console.WriteLine("Aprovado");
// else Console.WriteLine("Reprovado");

// // Operador Ternário ?

// Console.WriteLine(nota >= 7 ? "Aprovado" : "Reprovado");

// // Switch

// int dia = 3;

// switch(dia)
// {
//     case 1:
//         Console.WriteLine("Segunda");
//         break;
//     case 2:
//         Console.WriteLine("Terça");
//         break;
//     case 3:
//         Console.WriteLine("Quarta");
//         break;
//     default:
//         Console.WriteLine("Dia inválido");
//         break;
// }

// // SWITCH C# MODERNO

// dia = 6;

// string nomeDia = dia switch
// {
//     0 => "Domingo",
//     1 => "Segunda",
//     2 => "Terça",
//     3 => "Quarta",
//     4 => "Quinta",
//     5 => "Sexta",
//     6 => "Sábado",
//     _ => "Inválido"
// };

// Console.WriteLine(nomeDia);

// // CONDICIONAIS COM NULL

// double? nota1 = null;
// double notaFinal = nota1 ?? 0;

// Console.WriteLine(notaFinal);

// EXERCICIO 01

// PARTE 01

// Console.Write("Digite um número inteiro: ");
// string? entrada = Console.ReadLine();

// if (string.IsNullOrWhiteSpace(entrada))
// {
//     Console.WriteLine("Sua entrada não pode ser vazia ou nulla.");
//     return;
// }

// if(!int.TryParse(entrada, out int numero))
// {
//     Console.WriteLine("Por favor informar um número interio.");
//     return;
// }

// string ehParOuImpar = numero % 2 == 0 ? "Par" : "Impar";

// Console.WriteLine($"O número: {numero} é {ehParOuImpar}.");

// PARTE 02

// double LerNota(string mensagem)
// {
//     Console.Write(mensagem);
//     string? entrada = Console.ReadLine();

//     if (!double.TryParse(entrada, out double nota))
//     {
//         Console.WriteLine("Nota inválida.");
//         return -1;
//     }
//     return nota;
// }

// var n1 = LerNota("Digite a primeira nota: ");
// var n2 = LerNota("Digite a segunda nota: ");
// var n3 = LerNota("Digite a terceira nota: ");

// if (n1 < 0 || n2 < 0 || n3 < 0)
// {
//     Console.WriteLine("Erro na leitura das notas.");
//     return;
// }

// double media = (n1 + n2 + n3) / 3;
// string situacao = media >= 7 ? "Aprovado" : "Reprovado";

// Console.WriteLine($"Média: {media:F2} - Situação: {situacao}");

// PARTE 03:

Console.Write("Diget um númeero de 1 a 12: ");
string? entrada = Console.ReadLine();

if (!int.TryParse(entrada, out int mes))
{
    Console.WriteLine("Valor inválido.");
}

string nomeMes = mes switch
{
    1 =>    "Janeiro",
    2 =>    "Fevereiro",
    3 =>    "Março",
    4 =>    "Abril",
    5 =>    "Maio",
    6 =>    "Junho",
    7 =>    "Julho",
    8 =>    "Agosto",
    9 =>    "Setembro",
    10 =>   "Outubro",
    11 =>   "Nobembro",
    12 =>   "Dezembro",
    13 =>   "Mês inválido"
};

Console.WriteLine(nomeMes);
