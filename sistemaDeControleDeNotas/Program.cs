// TODO: CRIAÇÃO DAS VARIÁVIES
double media = 0;
double soma = 0;
int verificaMedia = 0;

// TODO: CRIAR VARIAVEL PARA ARMAZENAR AS NOTAS    
List<double> notas = new List<double>();

while (true)
{
    // TODO: CRIAR MENU
    Console.WriteLine("\n1 - Inserir nota\n2 - Calcular média\n3 - Mostrar Situação\n0 - Sair");

    // TODO: USUÁRIO DEVE ESCOLHER UMA OPÇÃO
    Console.Write("Insira a sua opção: ");
    string? entrada1 = Console.ReadLine();

    // TODO: CRIAR VALIDAÇÕES PARA SAIDO DO PROGRAMA

    // TODO: VALIDANDO ENTRADA1S CASO FOREM NULAS OU VAZIAS
    if (string.IsNullOrWhiteSpace(entrada1))
    {
        Console.WriteLine("Por favor, não digite valor nulo ou vazio.");
        continue;
    }

    // TODO: VALIDANDO TIPO DE VALOR
    if (!int.TryParse(entrada1, out int opcao))
    {
        Console.WriteLine("Por favor, digitar um valor inteiro.");
        continue;
    }

    // TODO: VALIDANDO O VALOR DO MENU
    if (opcao == 1)
    {
        // TODO: INSERIR NOTAS
        while (true)
        {
            Console.Write("Digite a nota: ");

            string? entrada2 = Console.ReadLine();

            // TODO: VALIDANDO VALOR SE É NULO OU VAZIO
            if (string.IsNullOrWhiteSpace(entrada2))
            {
                Console.WriteLine("Valor informado é nulo ou vazio. Por favor, digitar um valor válido.");
                continue;
            }

            // TODO: VALIDANDO O TIPO DO VALOR
            if (!double.TryParse(entrada2, out double nota))
            {
                Console.WriteLine("Por favor, digitar um valor válido.");
                continue;
            }

            // TODO: VALIDANDO RANGE DA NOTA OU INSERINDO O VALOR DA NOTA

            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("Por favor, digitar uma valor entre zero e dez.");
                continue;
            }
            else
            {
                notas.Add(nota);

                Console.WriteLine("Valor inserido com sucesso!");
                Console.WriteLine($"Numeros de notas Inseridas: {notas.Count}");

                break;
            }
        }
    }
    else if (opcao == 2)
    {
        if (notas.Count == 0)
        {
            Console.WriteLine("Não pode ser cálculado uma média para uma lista de notas vazia.");
        }
        else
        {
            verificaMedia += 1;

            foreach (var item in notas)
            {
                soma += item;
            }

            media = soma / notas.Count;

            Console.WriteLine($"Media: {media}.");
            soma = 0;
            media = 0;
        }
    }
    else if (opcao == 3)
    {
        string situacao;
        
        if (verificaMedia == 0)
        {
            Console.WriteLine("Vocẽ não pode solicitar a situação do aluno sem calcular a média dele.");
        }
        else
        {
            if (media >= 7)
            {
                situacao = "Aprovado";
            }
            else if (media < 5)
            {
                situacao = "Reprovado";
            }
            else
            {
                situacao = "Recuperação";
            }
            
            Console.WriteLine($"Situação do Aluno: {situacao}.");
        }
    }
    else if (opcao == 0)
    {
        Console.WriteLine("Saindo do Sistema...");
        break;
    }
    else
    {
        Console.WriteLine("Não existe essa opção. Por favor, insira um valor válido.");
    }
}
