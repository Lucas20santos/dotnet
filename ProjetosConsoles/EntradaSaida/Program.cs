// SAÍDA DE DADOS COM WRITELINE() E WRITE()

// Console.Write("Mensagem: "); // NAO PULA LINHA

// Console.WriteLine("Olá, Mundo!"); // PULA LINHA

// int Idade = 25;

// Console.WriteLine($"Idade: {Idade}"); // INTERPOLAÇÃO

// ENTRADA DE DADOS COM READLINE() E READ()

// Console.Write("Digite seu nome: ");
// string nome = Console.ReadLine();

// Console.WriteLine($"Olá, {nome}.");

// CONVERTENDO ENTRADA DO USUÁRIO

// -------- CONVERTENDO PARA INT ----------

// Console.Write("Digite sua idade: ");
// int idade = int.Parse(Console.ReadLine());

// Console.WriteLine($"Idade digitada: {idade}.");

// ---------- VALIDANDO A ENTRADA ----------

// bool sucesso = int.TryParse(Console.ReadLine(), out int idade);

// if (sucesso) Console.WriteLine($"Idade válida: {idade}"); else Console.WriteLine("Valor inválido!");

// EXEMPLO COMPLETO (ENTRADA + PROCESSAMENTO + SAIDA)


// Console.Write("Digite a primeira nota: ");
// double nota1 = double.Parse(Console.ReadLine());

// Console.Write("Digite a segunda nota: ");
// double nota2 = double.Parse(Console.ReadLine());

// double media = (nota1 + nota2) / 2;
// Console.WriteLine($"Média: {media}");

// ENTRADA COM VALORES OPCIONAIS (NULLABLE)

// Console.Write("Digite a nota (ou pressione Enter): ");
// string entrada = Console.ReadLine();

// double? nota = string.IsNullOrWhiteSpace(entrada) ? null : double.Parse(entrada);

// Console.WriteLine($"Nota: {nota ?? 0}");

// LENDO UM ÚNICO CARACTERE

// Console.Write("Dejesa continuar? (s/n): ");
// char opcao = Console.ReadKey().KeyChar;

// Console.WriteLine($"\nOpção escolhida: {opcao}");

// LIMPANDO O CONSOLE E PAUSANDO O PROGRAMA

// Console.Clear();

// Console.WriteLine("Pressione qualquer tecla para sair...");
// Console.ReadKey();

// ENTRADA E SAÍDA COM ARQUIVOS (INTRODUCAO)

// File.WriteAllText("dados.txt", "Olá arquivo");

// string conteudo = File.ReadAllText("dados.txt");
// Console.WriteLine(conteudo);

// EXERCICIO 01 - NOME VÁLIDO

// Console.Write("Digite seu nome: ");
// string nome = Console.ReadLine();

// Console.WriteLine(string.IsNullOrWhiteSpace(nome) || nome.Length < 3 ? "Nome Invalido ou curto demais": nome);


// EXERCICIO 02 - IDADE COM FAIXA VÁLIDA

// Console.Write("Digite a sua idade: ");
// string entrada = Console.ReadLine();

// if (string.IsNullOrWhiteSpace(entrada))
// {
//     Console.WriteLine("O valor informado para idade não pode ser nullo ou vazio.");
//     return;
// }

// if (!int.TryParse(entrada, out int idade))
// {
//     Console.WriteLine("Valor informado não é um numero interio.");
//     return;
// }

// if (idade < 0 || idade > 120)
// {
//     Console.WriteLine($"A idade {idade} fora do range [0:120].");
// }
// else
// {
//     Console.WriteLine($"A sua idade é {idade}.");
// }

// EXERCÍCIO 03 - MÉDIA DE NOTAS SEGURA

// Console.Write("Digite a primeira nota: ");
// string? entrada1 = Console.ReadLine();

// if (string.IsNullOrWhiteSpace(entrada1))
// {
//     Console.WriteLine("Valor não pode ser vazio ou nullo.");
//     return;
// }

// if (!double.TryParse(entrada1, out double nota1))
// {
//     Console.WriteLine("A nota informada não é um valor valido.");
//     return;
// }

// if (0 > nota1 || nota1 > 10)
// {
//     Console.WriteLine("Nota Digitada fora do range de [0 à 10].");
//     return;
// }

// Console.Write("Digite a segunda nota: ");
// string? entrada2 = Console.ReadLine();

// if (string.IsNullOrWhiteSpace(entrada2))
// {
//     Console.WriteLine("Valor não pode ser vazio ou nullo.");
//     return;
// }

// if (!double.TryParse(entrada2, out double nota2))
// {
//     Console.WriteLine("A nota informada não é um valor valido.");
//     return;
// }

// if (0 > nota2 || nota2 > 10)
// {
//     Console.WriteLine("Nota Digitada fora do range de [0 à 10].");
//     return;
// }

// double media = (nota1 + nota2) / 2;
// Console.WriteLine($"A média é {media}");

// EXERCICIO 04

// Console.Write("MENU:\n1- Cadastrar\n2 - Listar\n0 - Sair\n");
// string entrada = Console.ReadLine();

// if (string.IsNullOrWhiteSpace(entrada))
// {
//     Console.WriteLine("O valor informado não pode ser nullo ou vazio.");
//     return;
// }

// if (!int.TryParse(entrada, out int opcao))
// {
//     Console.WriteLine("Valor informado não é um numero interio.");
//     return;
// }

// if (opcao < 0 || opcao > 2)
// {
//     Console.WriteLine($"A opcao precisa está entre 0 - 2");
// }
// else
// {
//     if (opcao == 1) Console.WriteLine("Cadastro");
//     else if (opcao == 2) Console.WriteLine("Listando");
//     else Console.WriteLine("Saindo");
// }

// EXERCICIO 05 - CONFIRMAÇÃO (SIM OU NÃO)
