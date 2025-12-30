# Condicionais em C# — Guia Prático com Exemplos

---

## 1. `if`

Executa um bloco quando a condição é verdadeira.

```csharp
int idade = 18;

if (idade >= 18)
{
    Console.WriteLine("Maior de idade");
}
```

**Dica:** a condição precisa resultar em `bool` (`true` ou `false`).

---

## 2. `if` / `else`

Define um caminho alternativo quando a condição é falsa.

```csharp
int nota = 6;

if (nota >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}
```

---

## 3. `if` / `else if` / `else`

Usado quando há **múltiplas condições**.

```csharp
int nota = 8;

if (nota >= 9)
{
    Console.WriteLine("Excelente");
}
else if (nota >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}
```

**Ordem importa:** a primeira condição verdadeira encerra a verificação.

---

## 4. Operadores de Comparação

Usados para formar condições.

| Operador | Significado    |
| -------- | -------------- |
| `==`     | Igual          |
| `!=`     | Diferente      |
| `>`      | Maior          |
| `<`      | Menor          |
| `>=`     | Maior ou igual |
| `<=`     | Menor ou igual |

Exemplo:

```csharp
int a = 10;
int b = 5;

if (a > b)
{
    Console.WriteLine("a é maior que b");
}
```

---

## 5. Operadores Lógicos

Permitem combinar condições.

| Operador | Significado |   |         |
| -------- | ----------- | - | ------- |
| `&&`     | E (AND)     |   |         |
| `        |             | ` | OU (OR) |
| `!`      | NÃO (NOT)   |   |         |

```csharp
int idade = 20;
bool temHabilitacao = true;

if (idade >= 18 && temHabilitacao)
{
    Console.WriteLine("Pode dirigir");
}
```

---

## 6. Operador Ternário `? :`

Forma **compacta** de escrever `if/else`.

```csharp
int nota = 7;
string resultado = nota >= 7 ? "Aprovado" : "Reprovado";

Console.WriteLine(resultado);
```

Use quando a lógica for simples. Para regras complexas, prefira `if`.

---

## 7. `switch`

Ideal para **comparar um mesmo valor** com várias opções.

```csharp
int dia = 3;

switch (dia)
{
    case 1:
        Console.WriteLine("Segunda");
        break;
    case 2:
        Console.WriteLine("Terça");
        break;
    case 3:
        Console.WriteLine("Quarta");
        break;
    default:
        Console.WriteLine("Dia inválido");
        break;
}
```

---

## 8. `switch` (C# moderno)

Sintaxe mais limpa (C# 8+).

```csharp
int dia = 5;

string nomeDia = dia switch
{
    1 => "Segunda",
    2 => "Terça",
    3 => "Quarta",
    4 => "Quinta",
    5 => "Sexta",
    _ => "Inválido"
};

Console.WriteLine(nomeDia);
```

---

## 9. Condicionais com `null`

Uso do **operador de coalescência nula** `??`.

```csharp
double? nota1 = null;
double notaFinal = nota1 ?? 0;

Console.WriteLine(notaFinal);
```

Se `nota1` for `null`, o valor será `0`.

---

## 10. Boas Práticas

* Evite condições muito longas
* Use nomes claros para variáveis booleanas
* Prefira legibilidade a código "curto"
* Use `switch` quando houver muitos `else if`

---
