static float[] InserirNotas()
{
    int cont = 0;

    float[] notas = new float[5];

    while (true)
    {
        Console.Write($"Inserir Nota {cont + 1}: ");
        string? entrada = Console.ReadLine();

        if (TentarObterNota(entrada, out float nota))
        {
            if (ValidarInterValo(0, 10, nota))
            {
                notas[cont] = nota;
                cont++;
            }
            else
            {
                Console.WriteLine("A nota tem que ser entre 0 e 10.");
            }
        }
        else
        {
            Console.WriteLine("Valor inserido não é um número.");
        }

        if (cont == 5)
        {
            break;
        }
    }

    return notas;
}

static float CalcularMedia(float[] notas)
{
    return notas.Average();
}

static float MaiorNota(float[] notas)
{
    return notas.Max();
}

static float MenorNota(float[] notas)
{
    return notas.Min();
}

static void ExibirSituacao(float[] notas)
{
    if (CalcularMedia(notas) >= 7)
    {
        Console.WriteLine("Aluno: Aprovado.");
    }
    else if (CalcularMedia(notas) >= 5 || CalcularMedia(notas) < 7)
    {
        Console.WriteLine("Aluno de recuperação.");
    }
    else
    {
        Console.WriteLine("Aluno Reprovado.");
    }
}

static void ExibirNotas(float[] notas)
{
    foreach (var item in notas) Console.Write($"{item} -");
    Console.WriteLine();
}

static bool TentarObterNota(string? entrada, out float nota)
{
    if (string.IsNullOrWhiteSpace(entrada))
    {
        nota = -1;
        return false;
    }

    return float.TryParse(entrada, out nota);
}

static bool TentarObterOpcao(string? entrada, out int opcao)
{
    if (string.IsNullOrWhiteSpace(entrada))
    {
        opcao = -1;
        return false;
    }
    return int.TryParse(entrada, out opcao);
}

static bool ValidarInterValo(float menorNota, float maiorNota, float nota)
{
    if(nota >= menorNota && nota <= maiorNota)
    {
        return true;
    }
    else
    {
        return false;
    }
}

static void ApresentarAluno(float[] notas)
{
    ExibirNotas(notas);
    Console.WriteLine($"Maior Nota: {CalcularMedia(notas)}");
    Console.WriteLine($"Menor Nota: {CalcularMedia(notas)}");
    Console.WriteLine($"Média: {CalcularMedia(notas)}");
    ExibirSituacao(notas);
}

static void ApresentarMenu()
{
    Console.WriteLine("[1] - Inserir Notas: ");
    Console.WriteLine("[2] - Calcular Média:");
    Console.WriteLine("[3] - Apresentar Nota Mais Alta: ");
    Console.WriteLine("[4] - Apresentar Nota Mais Baixa: ");
    Console.WriteLine("[5] - Situação do Aluno: ");
    Console.WriteLine("[6] - Exibir Notas");
    Console.WriteLine("[7] - Informação Geral Do Aluno: ");
    Console.WriteLine("[0] - Sair do Programa.");
}

// Programa Principal
float[] notas = new float[5];
bool preencherVetor = false;

while (true)
{

    ApresentarMenu();
    Console.Write("Escolha sua opção: ");

    string? entrada = Console.ReadLine();

    if (TentarObterOpcao(entrada, out int opcao))
    {
        if (opcao == 1)
        {
            preencherVetor = true;
            notas = InserirNotas();
        }
        else if (opcao == 2)
        {
            if (preencherVetor)
            {
                Console.WriteLine($"Média: {CalcularMedia(notas)}");
            }
            else
            {
                Console.WriteLine("Você não pode acessar a média, pois as notas não foram todas inseridas.");
            }
        }
        else if (opcao == 3)
        {
            if (preencherVetor)
            {
                Console.WriteLine($"Maior Nota: {MaiorNota(notas)}");
            }
            else
            {
                Console.WriteLine("Você não pode acessar a Maior Nota, pois as notas não foram todas inseridas.");
            }
        }
        else if (opcao == 4)
        {
            if (preencherVetor)
            {
                Console.WriteLine($"Média: {MenorNota(notas)}");
            }
            else
            {
                Console.WriteLine("Você não pode acessar a Menor Nota, pois as notas não foram todas inseridas.");
            }
        }
        else if (opcao == 5)
        {
            if (preencherVetor)
            {
                ExibirSituacao(notas);
            }
            else
            {
                Console.WriteLine("Você não pode acessar a Situação do Aluno, pois as notas não foram todas inseridas.");
            }
        }
        else if (opcao == 6)
        {
            if (preencherVetor)
            {
                ExibirNotas(notas);
            }
            else
            {
                Console.WriteLine("Você não pode acessar as Notas do ALuno, pois as notas não foram todas inseridas.");
            }
        }
        else if (opcao == 7)
        {
            if (preencherVetor)
            {
                ApresentarAluno(notas);
            }
            else
            {
                Console.WriteLine("Você não pode acessar as Informações Gerais do Aluno, pois as notas não foram todas inseridas.");
            }
        }
        else if (opcao == 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Opção escolhida inválida.");
        }
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }
}

Console.WriteLine("Final do programa.");
