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

// while (true)
// {
//     Console.Write("Digite um número: ");
//     string entrada = Console.ReadLine();

//     if (string.IsNullOrWhiteSpace(entrada))
//     {
//         Console.WriteLine("Digite um valor que não seja nulo ou vazio.");
//         continue;
//     }

//     if (!int.TryParse(entrada, out int numero))
//     {
//         Console.WriteLine("Por favor, inserir um número interio");
//         continue;
//     }

//     if (numero == 0)
//     {
//         Console.WriteLine("Você digitou o número zero. Saindo da Aplicação...");
//         break;
//     }

//     Console.WriteLine($"\nTabuada do número {numero}: ");
//     Console.WriteLine();

//     for (int i = 0; i <= 10; i++)
//     {
//         Console.WriteLine($"{numero} x {i} = {numero * i}");
//     }
// }

// EXERCICIO 04 PERCORRA UMA LISTA DE NOMES E MOSTRE APNEAS OS QUE COMEÇAM COM A LETRA **A**

// VALIDAÇÕES NECESSÁRIAS

/*
Antes de adicionar à lista, valide:

✅ não é null
✅ não é vazia
✅ não é espaço em branco

*/
// List<string> nomes = new List<string>();

// while (true)
// {
//     Console.Write("Digite um nome: ");
//     // Precisamos validar os dados aqui, antes de add
//     string entrada = Console.ReadLine();

//     if (string.IsNullOrWhiteSpace(entrada)) Console.WriteLine("Nome informado está vazio ou é nulo ou está em branco. Por favor, digitar um valor válido.");
//     else
//     {
//         nomes.Add(entrada.Trim());
//         Console.WriteLine($"Nome: {entrada.Trim()} inserido com sucesso!");
//         Console.WriteLine($"Quantidade de Nomes na Lista: {nomes.Count}");
//     }

//     Console.Write("Digite S ou s para sair. ");
//     string opcao = Console.ReadLine();

//     if (opcao.StartsWith('S', StringComparison.OrdinalIgnoreCase)) break;
// }

// Console.Clear();
// Console.WriteLine("========================================================");
// Console.WriteLine("Os nomes digitados que começam com a Letra 'A': ");
// Console.WriteLine("========================================================");

// Console.WriteLine("Index - Nomes");

// for (int i = 0; i < nomes.Count; i++)
// {
//     if (nomes[i].StartsWith('A', StringComparison.OrdinalIgnoreCase)) Console.WriteLine($"[{i + 1}]   - {nomes[i]}");
// }

// Console.WriteLine("========================================================");

/* 
    EXERCICIO 06: CRIE UM MENU SIMPLES
    1 - SOMAR NÚMEROS
    2 - SUBTRAIR NUMEROS
    0 - SAIR

    O PROGRAMA DEVE CONTINUAR EXECUTANDO ATÉ O USUÁRIO ESCOLHER SAIR.
*/

while (true)
{
    // ENTRADA
    Console.WriteLine("========================================================");
    Console.WriteLine("1 - Somar números\n2 - Subtrair números\n0 - Sair");
    Console.WriteLine("========================================================");
    
    Console.Write("Escolha sua opção: ");
    string? entrada = Console.ReadLine();
    
    // PROCESSAMENTO DO DADO
    if (string.IsNullOrWhiteSpace(entrada))
    {
        Console.WriteLine("Valor digitado incompatível. Por favor, não digitar um valor nulo ou vazio.");
        continue;
    }

    if (!int.TryParse(entrada, out int opcao))
    {
        Console.WriteLine("Valor digitado incompatível. Por favor, digitar um valor inteiro.");
        continue;
    }

    string acao = opcao switch
    {
        1 => "Somando",
        2 => "Subtraindo",
        _ => "Valor Inválido"
    };

    // SAIDA

    if (opcao == 0) break;
    else Console.WriteLine(acao);

}
