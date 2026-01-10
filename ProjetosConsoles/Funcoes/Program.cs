// EXERCICIO 01 - FUNÇÃO SEM PARÂMETROS E SEM RETORNO

// static void ExibirMensagem()
// {
//     Console.WriteLine("Bem-vidno ao estudo de funções em C#");
// }

// // MAIN()

// ExibirMensagem();

// // EXERCICIO 02 - FUNCAO COM PARÂMETRO (STRING)

// static void ExibirMensagemComParametro(string nome)
// {
//     Console.WriteLine($"Olá, {nome}.");
// }

// // MAIN

// ExibirMensagemComParametro("Lucas");

// // EXERCICIO 03 - FUNÇÃO COM RETORNO INT

// static int SomarDoisNumerosInteiros(int a, int b)
// {
//     return a + b;
// }

// // MAIN

// Console.WriteLine(SomarDoisNumerosInteiros(5, 6));

// FUNÇÃO COM RETORNO BOOL

/*
    CRIE UMA FUNÇÃO QUE RECEBA UM NÚMERO INTEIRO E RETORNE TRUE SE ELE
    FOR PAR, OU FALSE CASO CONTRARIO.
*/

// MINHA SOLUÇÃO
// static bool ValidarNumeroNaoVazioOuNulo(string numero)
// {
//     return !string.IsNullOrWhiteSpace(numero);
// }

// static bool ValidaSeNumeroEhInteiro(string numero, out int num)
// {
//     return int.TryParse(numero, out num);
// }

// static bool NumeroEhParOuImpar(string numero)
// {
//     if (ValidarNumeroNaoVazioOuNulo(numero) && ValidaSeNumeroEhInteiro(numero, out int num))
//     {
//         return num % 2 == 0;
//     }
//     return false;
// }

// Console.WriteLine(NumeroEhParOuImpar("abc") ? "O Número é Par.": "O Número é Impar.");

// SOLUÇÃO MELHORADA

static bool TentarObterNumero(string entrada, out int numero)
{
    if (string.IsNullOrWhiteSpace(entrada))
    {
        numero = 0;
        return false;
    }

    return int.TryParse(entrada, out numero);
}

static bool NumeroEhPar(int numero)
{
    return numero % 2 == 0;
}

string entrada = "20";

if(TentarObterNumero(entrada, out int numero))
{
    Console.WriteLine(
NumeroEhPar(numero) ? "O número informado é par." : "O número informado é impar."
    );
}
else
{
    Console.WriteLine("Entrada inválida.");
}

// EXERCICIO 05 - CRIE UMA FUNÇAÕ QUE RECEBA UMA STRING E RETORNE TRUE SE ELA PUDER SER CONVERTIDA PARA INT

// static bool FuncaoConverterDeStringParaInt(string numero, out int num)
// {
//     return int.TryParse(numero, out num);
// }

// string numero = "20a";

// if (FuncaoConverterDeStringParaInt(numero, out int num))
// {
//     Console.WriteLine($"A entrada {num} foi convertida com sucesso.");
// }
// else
// {
//     Console.WriteLine("A entrada não foi convertida com sucesso.");    
// }

// // EXERCICIO 11 - CRIE UMA FUNNÇÃO QUE RECEBA VÁRIOS NÚMEROS INTEIROS E RETORNE A SOAM DELES.

// static int RetornarSomaDeVariosNumerosInteiro(params int[] numeros)
// {
//     int soma = 0;

//     if (numeros.Length != 0)
//     {
//         foreach (var item in numeros)
//         {
//             soma += item;
//         }

//         return soma;
//     }

//     return 0;
// }

// Console.WriteLine($"Soma = {RetornarSomaDeVariosNumerosInteiro([1, 2, 3, 4])}");
// Console.WriteLine($"Soma = {RetornarSomaDeVariosNumerosInteiro([])}");

