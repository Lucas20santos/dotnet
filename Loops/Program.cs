// EXERCICIO 01

// for (int i = 1; i <= 10; i++)
// {
//     Console.Write($"{i} ");
// }

// Console.WriteLine();

// EXERCICIO 02

// while(true)
// {
//     Console.Write("Digite um número: ");
//     string entrada = Console.ReadLine();

//     if (string.IsNullOrWhiteSpace(entrada))
//     {
//         Console.WriteLine("Digite um valor que não seja nullo ou vazio.");
//         continue;
//     }

//     if (!int.TryParse(entrada, out int numero))
//     {
//         Console.WriteLine("Por favor, inserir um número interio");
//         continue;
//     }

//     if(numero == 0)
//     {
//         Console.WriteLine("Você digitou o número zero. Saindo da Aplicação...");
//         break;
//     }

//     Console.WriteLine($"Número digitado: {numero}");
// }

// EXERCICIO 03 - PEÇA UM NÚMERO E MOSTRE A **TABUADA** DELE (1 A 10).

while (true)
{
    Console.Write("Digite um número: ");
    string entrada = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("Digite um valor que não seja nulo ou vazio.");
        continue;
    }

    if (!int.TryParse(entrada, out int numero))
    {
        Console.WriteLine("Por favor, inserir um número interio");
        continue;
    }

    if (numero == 0)
    {
        Console.WriteLine("Você digitou o número zero. Saindo da Aplicação...");
        break;
    }

    Console.WriteLine($"\nTabuada do número {numero}: ");
    Console.WriteLine();

    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}
