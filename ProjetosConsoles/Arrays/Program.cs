// EXERCICIO 01 - CRIANDO E EXIBINDO UM ARRAY

// int[] numeros = new int[] {10, 20, 30, 40, 50};

// for (int i = 0; i < numeros.Length; i++) Console.WriteLine(numeros[i]);

// foreach (var item in numeros) Console.WriteLine(item);

// EXERCICIO 02 - SOMA DOS ELEMENTOS

// int[] numeros = new int[] { 20, 40, 60, 80 };
// int soma = 0;

// foreach (var item in numeros) soma += item;

// Console.WriteLine($"A soma dos elementos é {soma}");

// COM LINQ

// soma = numeros.Sum();

// EXERCICIO 03 - MAIOR VALOR DO ARRAY

// int[] numeros = new int[] { 20, 12, 9, 23 };
// int maior = numeros[0];

// for(int i = 0; i < numeros.Length; i++) if (maior < numeros[i]) maior = numeros[i];

// Console.WriteLine($"O maior valor do array é: {maior}");

// maior = numeros.Max();

// Console.WriteLine($"O maior valor do array é: {maior}");

// EXERCICIO 04 - MÉDIA DE NOTAS

// float[] notas = new float[] { 7, 4, 8, 9 };
// float soma = 0;
// float media = 0;

// if (notas.Length == 0)
// {
//     Console.WriteLine("Não existe notas disponivel");
// }
// else if(notas.Length == 1)
// {
//     media = notas[0];
// }
// else
// {
//     for (int i = 0; i < notas.Length; i++) soma += notas[i];

//     media = soma / notas.Length;
// }

// Console.WriteLine($"A média é de {media}.");

// media = notas.Average();

// Console.WriteLine($"A média é de {media}.");

// EXERCICIO 05 - CONTAR NÚMEROS PARES

// int[] numeros = { 11, 12, 13, 14, 15, 16 };
// int somaNumerosPares = 0;

// foreach (var item in numeros) if (item % 2 == 0) somaNumerosPares += item;

// Console.WriteLine($"A soma dos números pares: {somaNumerosPares}.");

// int contarPares = numeros.Where(n => n % 2 == 0).Count();

// Console.WriteLine($"A quantidade de números pares: {contarPares}.");

// EXERCICIO 06 - BUSCAR UM VALOR NO ARRAY

// int[] numeros = { 11, 12, 13, 14, 15, 16 };
// int numeroProcurado = 15;

// bool encontrou = numeros.Any(x => x == numeroProcurado);

// int indice = numeros
// .Select((valor, index) => new { valor, index })
// .Where(x => x.valor == numeroProcurado)
// .Select(x => x.index)
// .DefaultIfEmpty(-1)
// .First();

// Console.WriteLine($"{encontrou}, {indice}");

// INVERTER O ARRAY

// int[] numeros = { 11, 12, 13, 14, 15, 16 };
// int[] numerosInvertido = new int[numeros.Length];

// for (int i = 0; i < numeros.Length; i++)
// {
//     numerosInvertido[numeros.Length - 1 - i] = numeros[i];
// }

// Console.WriteLine("Vetor Original: ");

// for (int i = 0; i < numeros.Length; i++)
// {
//     Console.Write($"{numeros[i]} ");
// }

// Console.WriteLine();
// Console.WriteLine("Vetor Invertido: ");

// for (int i = 0; i < numerosInvertido.Length; i++)
// {
//     Console.Write($"{numerosInvertido[i]} ");
// }

// Console.WriteLine();

// // COM LINQ

// int[] revertido = numeros.Reverse().ToArray();

// CONTAR OCORRENCIA

// int[] numeros = { 1, 2, 3, 1, 1, 4 };
// int cont = 0, numero = 1;

// foreach (var item in numeros) if (item == numero) cont++;

// Console.WriteLine($"O número: {numero} apareceu {cont} vezes.");

// cont = numeros.Where(n => n == numero).Count();

// Console.WriteLine($"O número: {numero} apareceu {cont} vezes.");

// EXERCICIO 09 - SEPARAR PARES E IMPARES

int[] numeros = { 1, 2, 3, 4, 5, 6, 7 };
int cont1 = 0, cont2 = 0;
int contPar = 0, contImpar = 0;

foreach(var item in numeros) if(item % 2 == 0) cont1++;

cont2 = numeros.Length - cont1;

int[] numerosPares = new int[cont1];
int[] numerosImpares = new int[cont2];


foreach (var item in numeros)
{
    if (item % 2 == 0)
    {
        numerosPares[contPar] = item;
        contPar++;
    }
    else
    {
        numerosImpares[contImpar] = item;
        contImpar++;
    }
}

for (int i = 0; i < cont1; i++) Console.WriteLine(numerosPares[i]);
for (int i = 0; i < cont2; i++) Console.WriteLine(numerosImpares[i]);

int[] par = numeros.Where(n => n % 2 == 0);
int[] impar = numeros.Where(n => n % 2 == 1);
