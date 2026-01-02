# Laços de Repetição (Loops) em C# — Guia Completo e Básico

Este material foi feito para **quem está começando em C#**, explicando **o que são loops**, **quando usar cada um**, exemplos com **entrada de dados**, **boas práticas de código** e **exercícios no final**.

---

## 1. O que são Laços de Repetição?

Laços de repetição (ou *loops*) permitem **executar o mesmo bloco de código várias vezes**, enquanto uma condição for verdadeira.

👉 Usamos loops quando não sabemos ou não queremos repetir código manualmente.

Exemplo do problema:

> Mostrar os números de 1 até 10

Sem loop (ruim ❌):

```csharp
Console.WriteLine(1);
Console.WriteLine(2);
Console.WriteLine(3);
```

Com loop (bom ✅):

```csharp
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
```

---

## 2. Loop `for`

### Quando usar?

* Quando você **sabe quantas vezes** quer repetir
* Contadores (1 a 10, 0 a 100, etc.)

### Estrutura do `for`

```csharp
for (inicialização; condição; incremento)
{
    // código repetido
}
```

### Exemplo básico

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Valor de i: {i}");
}
```

---

## 3. Loop `while`

### Quando usar\?

* Quando **não sabemos** quantas repetições serão necessárias
* Depende de uma condição

### Estrutura

```csharp
while (condição)
{
    // código
}
```

### Exemplo

```csharp
int contador = 1;

while (contador <= 5)
{
    Console.WriteLine(contador);
    contador++;
}
```

⚠️ **Cuidado:** se a condição nunca ficar falsa, o loop será infinito.

---

## 4. Loop `do while`

### Diferença do `while`

* O bloco executa **pelo menos uma vez**, mesmo se a condição for falsa

### \Estrutura

```csharp
do
{
    // código
}
while (condição);
```

### \Exemplo

```csharp
int opcao;

do
{
    Console.Write("Digite um número maior que zero: ");
    int.TryParse(Console.ReadLine(), out opcao);
}
while (opcao <= 0);
```

---

## 5. Loop `foreach`

### Quando usar?

* Para percorrer **coleções** (arrays, listas)
* Quando não precisa do índice

### Exemplo com array

```csharp
string[] nomes = { "Ana", "João", "Lucas" };

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}
```

---

## 6. `break` e `continue`

### `break`

Encerra o loop imediatamente.

```csharp
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
        break;

    Console.WriteLine(i);
}
```

### `continue`

Pula a iteração atual.

```csharp
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
        continue;

    Console.WriteLine(i);
}
```

---

## 7. Loops com Entrada de Dados (`TryParse`)

### Exemplo: repetir até entrada válida

```csharp
int numero;

while (true)
{
    Console.Write("Digite um número inteiro: ");

    if (int.TryParse(Console.ReadLine(), out numero))
        break;

    Console.WriteLine("Entrada inválida, tente novamente.");
}
```

---

## 8. Boas Práticas (Nível Estágio / Júnior)

✔ Evite loops infinitos sem necessidade
✔ Sempre valide entrada do usuário
✔ Use nomes claros (`contador`, `indice`)
✔ Prefira `foreach` para listas e arrays
✔ Use `break` com cuidado

---

## 9. Exercícios Propostos

### Exercício 1 (Básico)

Mostre os números de **1 a 10** usando `for`.

### Exercício 2 (Intermediário)

Leia números do usuário até que ele digite **0**.

### Exercício 3 (Intermediário)

Peça um número e mostre a **tabuada** dele (1 a 10).

### Exercício 4 (Coleções)

Percorra uma lista de nomes e mostre apenas os que começam com a letra **A**.

### Exercício 5 (Desafio)

Crie um menu simples:
1 - Somar números
2 - Subtrair números
0 - Sair

O programa deve continuar executando até o usuário escolher sair.

---

## 10. Próximo Passo

* Loops + **condicionais**
* Loops + **listas (`List<T>`)**
* Mini-projetos de console (menu, cadastro, jogo simples)

Se quiser, posso **resolver os exercícios passo a passo** ou criar um **mini-projeto completo** usando loops.
