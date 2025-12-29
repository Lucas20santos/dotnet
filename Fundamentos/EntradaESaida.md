# 📘 Entrada e Saída em C# (Input / Output)

Em C#, **entrada** é quando o programa recebe dados (usuário, arquivos, etc.) e **saída** é quando o programa exibe ou grava dados.

Vamos focar primeiro em **console**, que é a base para entender o restante.

---

## 1️⃣ Saída de dados no Console

### 🔹 `Console.WriteLine`

Exibe um texto **e pula linha**.

```csharp
Console.WriteLine("Olá, mundo!");
```

### 🔹 `Console.Write`

Exibe um texto **sem pular linha**.

```csharp
Console.Write("Digite seu nome: ");
```

### 🔹 Exibindo variáveis

```csharp
int idade = 25;
Console.WriteLine("Idade: " + idade);
```

Ou usando **interpolação de strings** (recomendado):

```csharp
Console.WriteLine($"Idade: {idade}");
```

---

## 2️⃣ Entrada de dados pelo Console

### 🔹 `Console.ReadLine()`

Lê uma linha digitada pelo usuário (sempre retorna `string`).

```csharp
Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Olá, {nome}!");
```

---

## 3️⃣ Convertendo entrada do usuário

Como `ReadLine()` retorna `string`, precisamos converter para outros tipos.

### 🔹 Convertendo para `int`

```csharp
Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Idade digitada: {idade}");
```

⚠️ **Cuidado**: se o usuário digitar algo inválido, o programa quebra.

---

## 4️⃣ Entrada segura com `TryParse`

Forma **mais correta** de ler números.

```csharp
Console.Write("Digite sua idade: ");
bool sucesso = int.TryParse(Console.ReadLine(), out int idade);

if (sucesso)
{
    Console.WriteLine($"Idade válida: {idade}");
}
else
{
    Console.WriteLine("Valor inválido!");
}
```

---

## 5️⃣ Exemplo completo (entrada + processamento + saída)

### 📌 Calculando média de notas

```csharp
Console.Write("Digite a primeira nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2) / 2;

Console.WriteLine($"Média: {media}");
```

---

## 6️⃣ Entrada com valores opcionais (nullable)

```csharp
Console.Write("Digite a nota (ou pressione Enter): ");
string entrada = Console.ReadLine();

double? nota = string.IsNullOrWhiteSpace(entrada)
    ? null
    : double.Parse(entrada);

Console.WriteLine($"Nota: {nota ?? 0}");
```

---

## 7️⃣ Lendo um único caractere

```csharp
Console.Write("Deseja continuar? (s/n): ");
char opcao = Console.ReadKey().KeyChar;

Console.WriteLine($"\nOpção escolhida: {opcao}");
```

---

## 8️⃣ Limpando o console e pausando o programa

### 🔹 Limpar tela

```csharp
Console.Clear();
```

### 🔹 Pausar execução

```csharp
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();
```

---

## 9️⃣ Entrada e saída com arquivos (introdução)

### 🔹 Escrevendo em arquivo

```csharp
File.WriteAllText("dados.txt", "Olá arquivo!");
```

### 🔹 Lendo de arquivo

```csharp
string conteudo = File.ReadAllText("dados.txt");
Console.WriteLine(conteudo);
```

---

## 🔟 Resumo rápido

| Ação            | Método                                  |
| --------------- | --------------------------------------- |
| Exibir texto    | `Console.WriteLine()`                   |
| Ler texto       | `Console.ReadLine()`                    |
| Ler tecla       | `Console.ReadKey()`                     |
| Converter dados | `int.Parse()` / `TryParse()`            |
| Saída formatada | `$"Texto {variavel}"`                   |
| Arquivos        | `File.ReadAllText()` / `WriteAllText()` |

---
