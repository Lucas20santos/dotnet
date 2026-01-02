// EXERCICIO 01

// for (int i = 1; i <= 10; i++)
// {
//     Console.Write($"{i} ");
// }

// Console.WriteLine();

// EXERCICIO 02

while(true)
{
    Console.Write("Digite um número: ");
    string entrada = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("Digite um valor que não seja nullo ou vazio.");
        continue;
    }

    if (!int.TryParse(entrada, out int numero))
    {
        Console.WriteLine("Por favor, inserir um número interio");
        continue;
    }

    if(numero == 0)
    {
        Console.WriteLine("Você digitou o número zero. Saindo da Aplicação...");
        break;
    }

    Console.WriteLine($"Número digitado: {numero}");
}
