// EXEMPLOS SIMPES

/*
    VOID - SIGNIFICA QUE A FUNÇAÕ NÃO RETORNA NADA
*/

// FUNÇÕES SEM RETORNO
static void Saudacao()
{
    Console.WriteLine("Olá, bem-vindo ao C#.");
}

// FUNÇÕES SEM RETORNO E COM PARAMETRO

static void MostrarMensagem(string nome)
{
    Console.WriteLine($"{nome},");
}

// FUNÇÕES QUE RETORNAM VALORES

static int Somar(int a, int b)
{
    return a + b;
}

// FUNÇÃO COM PARÂMETROS + RETORNO

static double CalcularMedia(double n1, double n2)
{
    return (n1 + n2) / 2;
}

// FUNÇÕES COM TIPOS NULLABLE

static double CalcularMediaNullable(double? n1, double? n2)
{
    return ((n1 ?? 0) + (n2 ?? 0)) / 2;
}

// FUNÇÕES COM VALIDAÇÕES (BOAS PRÁTICAS)

static bool EhNumeroValido(string entrada)
{
    return int.TryParse(entrada, out _);
}

// FUNÇÕES COM OUT

static bool TentarConverter(string texto, out int numero)
{
    return int.TryParse(texto, out numero);
}

// FUNÇÕES COM PARAMETROS OPCIONAIS
static void ExibirMensagem(string mensagem = "Olá")
{
    Console.WriteLine(mensagem);
}

// FUNÇÕES COM PARAMS
static int SomarTudo(params int[] numeros)
{
    int soma = 0;
    foreach (var item in numeros)
    {
        soma += item;
    }

    return soma;
}

// CHAMADA DA FUNÇÕES
MostrarMensagem("Lucas");
Saudacao();

Console.WriteLine($"O retorno da função Somar é {Somar(5, 7)}");
Console.WriteLine($"A Média de 7 e 5 é {CalcularMedia(7, 5)}.");
Console.WriteLine($"A Média de null e 5 é {CalcularMediaNullable(null, 5)}.");

if (EhNumeroValido("10"))
{
    Console.WriteLine("Número válido.");
}

if(TentarConverter("20", out int n))
{
    Console.WriteLine($"O valor convertido é {n}");
}

ExibirMensagem();
ExibirMensagem("Bem-Vindo!");
Console.WriteLine($"O valor da soma de [1, 2, 3, 4, 5] é {SomarTudo([1, 2, 3, 4, 5])}");
Console.WriteLine($"O valor da soma de [1, 2, 3, 4] é {SomarTudo([1, 2, 3, 4])}");
