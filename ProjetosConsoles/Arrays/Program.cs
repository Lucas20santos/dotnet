// EXERCICIO 01 - CRIANDO E EXIBINDO UM ARRAY

// int[] numeros = new int[] {10, 20, 30, 40, 50};

// for (int i = 0; i < numeros.Length; i++) Console.WriteLine(numeros[i]);

// foreach (var item in numeros) Console.WriteLine(item);

// EXERCICIO 02 - SOMA DOS ELEMENTOS

// int[] numeros = new int[] { 20, 40, 60, 80 };
// int soma = 0;

// foreach (var item in numeros) soma += item;

// Console.WriteLine($"A soma dos elementos é {soma}");

// EXERCICIO 03 - MAIOR VALOR DO ARRAY

// int[] numeros = new int[] { 20, 12, 9, 23 };
// int maior = numeros[0];

// for(int i = 0; i < numeros.Length; i++) if (maior < numeros[i]) maior = numeros[i];

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

// EXERCICIO 05 - CONTAR NÚMEROS PARES

// int[] numeros = { 11, 12, 13, 14, 15, 16 };
// int somaNumerosPares = 0;

// foreach (var item in numeros) if (item % 2 == 0) somaNumerosPares += item;

// Console.WriteLine($"A soma dos números pares: {somaNumerosPares}.");

// EXERCICIO 07 - BUSCAR UM VALOR NO ARRAY


int[] numeros = { 11, 12, 13, 14, 15, 16 };
int numeroProcurado = 17;

bool encontrou = numeros.Any(x => x == numeroProcurado);

int indice = numeros
.Select((valor, index) => new { valor, index })
.Where(x => x.valor == numeroProcurado)
.Select(x => x.index)
.DefaultIfEmpty(-1)
.First();

Console.WriteLine($"{encontrou}, {indice}");
