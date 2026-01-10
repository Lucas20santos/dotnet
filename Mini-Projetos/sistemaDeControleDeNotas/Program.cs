// TODO: função para calcular méida
static float CalcularMedia(float[] notas)
{
    return notas.Average();
}

// TODO: função para retornar a maior nota
static float MaiorNota(float[] notas)
{
    return notas.Max();
}

// TODO: função para retornar a menor nota
static float MenorNota(float[] notas)
{
    return notas.Min();
}

// Todo: função para exibir todas as notas
static void ExibirNotas(float[] notas)
{
    foreach (var item in notas) Console.Write($"{item} -");
    Console.WriteLine();
}

// Validar nota
static bool TentarObterNota(string entrada, out float nota)
{
    if (string.IsNullOrWhiteSpace(entrada))
    {
        nota = -1;
        return false;
    }

    return float.TryParse(entrada, out nota);
}

// TODO: criar um array para armazenar as notas no Array de tamanho fixo de 5 valores float ou double
float[] notas;
int cont = 0;

while(true)
{
    Console.WriteLine("1 - Inserir notas\n2 - Exibir Dados\n3 - Sair Do Programa");
}

// TODO: Chame a função aqui passando as notas
CalcularMedia(notas);
MaiorNota(notas);
MenorNota(notas);
ExibirNotas(notas);
