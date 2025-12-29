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

Console.Write("Digite a sua idade: ");
string entrada = Console.ReadLine();

entrada = string.IsNullOrWhiteSpace(entrada) ? null : entrada;

bool sucesso = int.TryParse(entrada ?? "0", out int idade);
bool idadeDentroDeRange = (idade > 0) && (idade < 120);

Console.WriteLine(sucesso && idadeDentroDeRange ? $"Idade: {idade}" : "Valor Invalido");

