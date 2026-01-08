Perfeito, Lucas 👍
Vamos montar **um material didático e bem organizado sobre Arrays em C#**, no mesmo estilo que você vem usando para estudar e postar depois (se quiser).

---

# 📌 ARRAYS EM C# — MATERIAL COMPLETO

## 🔹 O que é um Array?

Um **array** é uma estrutura de dados que permite armazenar **vários valores do mesmo tipo** em uma única variável.

📌 Características importantes:

* Tamanho **fixo** (definido na criação)
* Índices começam em **0**
* Todos os elementos são do **mesmo tipo**

---

## 🔹 Declarando um Array

### Forma mais simples

```csharp
int[] numeros;
```

### Declarando e definindo o tamanho

```csharp
int[] numeros = new int[5];
```

➡️ Esse array pode armazenar **5 números inteiros**, inicialmente todos valendo `0`.

---

## 🔹 Inicializando um Array

### Inicialização direta:

```csharp
int[] numeros = { 10, 20, 30, 40, 50 };
```

### Inicialização com tamanho definido

```csharp
int[] numeros = new int[] { 10, 20, 30 };
```

---

## 🔹 Acessando elementos do Array

```csharp
int[] numeros = { 10, 20, 30 };

Console.WriteLine(numeros[0]); // 10
Console.WriteLine(numeros[1]); // 20
Console.WriteLine(numeros[2]); // 30
```

⚠️ **Cuidado:** acessar um índice inválido gera erro (`IndexOutOfRangeException`).

---

## 🔹 Alterando valores do Array

```csharp
numeros[1] = 99;
```

Agora o array fica:

```yarm
[10, 99, 30]
```

---

## 🔹 Percorrendo um Array

### Usando `for`

```csharp
int[] numeros = { 10, 20, 30 };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}
```

📌 `Length` retorna o tamanho do array.

---

### Usando `foreach` (mais seguro e limpo)

```csharp
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
```

➡️ Ideal quando **não precisa do índice**.

---

## 🔹 Array de Strings

```csharp
string[] nomes = { "Lucas", "Ana", "João" };

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}
```

---

## 🔹 Array de `double`

```csharp
double[] notas = { 7.5, 8.0, 9.2 };

double soma = 0;

foreach (double nota in notas)
{
    soma += nota;
}

double media = soma / notas.Length;
Console.WriteLine($"Média: {media}");
```

📌 Exemplo bem comum em lógica de programação.

---

## 🔹 Boas práticas com Arrays

✔️ Sempre validar o tamanho antes de acessar índices
✔️ Usar `foreach` quando possível
✔️ Preferir `List<T>` quando precisar de tamanho dinâmico
✔️ Nomes claros (`notas`, `numeros`, `nomesAlunos`)

---

## 🔹 Array vs List (conceito rápido)

| Array             | List                   |
| ----------------- | ---------------------- |
| Tamanho fixo      | Tamanho dinâmico       |
| Mais performático | Mais flexível          |
| Menos recursos    | Muitos métodos prontos |

---

## 🔹 Quando usar Array?

✔️ Quantidade de elementos conhecida
✔️ Estruturas simples
✔️ Performance importa

---

## 🧠 Resumo mental

> **Array = vários valores do mesmo tipo, tamanho fixo, acessados por índice**

---
