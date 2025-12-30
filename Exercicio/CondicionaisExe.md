# Exercicios

## 1. Exercícios Propostos

1. Verifique se um número é **par ou ímpar**
2. Calcule a **média de 3 notas** e exiba a situação
3. Receba um número de 1 a 12 e mostre o **mês correspondente** usando `switch`

---

## 2. Exercícios Resolvidos (Passo a Passo)

### Exercício 1 — Número Par ou Ímpar

**Objetivo:** Ler um número inteiro e informar se ele é par ou ímpar.

#### Passo 1: Ler a entrada do usuário

```csharp
Console.Write("Digite um número inteiro: ");
string? entrada = Console.ReadLine();
```

#### Passo 2: Converter com `TryParse`

```csharp
bool sucesso = int.TryParse(entrada, out int numero);

if (!sucesso)
{
    Console.WriteLine("Entrada inválida. Digite apenas números inteiros.");
    return;
}
```

#### Passo 3: Aplicar a condição

```csharp
if (numero % 2 == 0)
{
    Console.WriteLine("Número par");
}
else
{
    Console.WriteLine("Número ímpar");
}
```

---

### Exercício 2 — Média de 3 Notas

**Objetivo:** Calcular a média e exibir a situação do aluno.

#### Passo 1: Ler e validar as notas

```csharp
double LerNota(string mensagem)
{
    Console.Write(mensagem);
    string? entrada = Console.ReadLine();

    if (!double.TryParse(entrada, out double nota))
    {
        Console.WriteLine("Nota inválida.");
        return -1;
    }

    return nota;
}

var n1 = LerNota("Digite a primeira nota: ");
var n2 = LerNota("Digite a segunda nota: ");
var n3 = LerNota("Digite a terceira nota: ");

if (n1 < 0 || n2 < 0 || n3 < 0)
{
    Console.WriteLine("Erro na leitura das notas.");
    return;
}
```

#### Passo 2: Calcular média e situação

```csharp
double media = (n1 + n2 + n3) / 3;
string situacao = media >= 7 ? "Aprovado" : "Reprovado";

Console.WriteLine($"Média: {media:F2} - Situação: {situacao}");
```

---

### Exercício 3 — Mês do Ano (`switch`)

**Objetivo:** Receber um número e exibir o mês correspondente.

```csharp
Console.Write("Digite um número de 1 a 12: ");
string? entrada = Console.ReadLine();

if (!int.TryParse(entrada, out int mes))
{
    Console.WriteLine("Valor inválido.");
    return;
}

string nomeMes = mes switch
{
    1 => "Janeiro",
    2 => "Fevereiro",
    3 => "Março",
    4 => "Abril",
    5 => "Maio",
    6 => "Junho",
    7 => "Julho",
    8 => "Agosto",
    9 => "Setembro",
    10 => "Outubro",
    11 => "Novembro",
    12 => "Dezembro",
    _ => "Mês inválido"
};

Console.WriteLine(nomeMes);
```

---

## 3. Boas Práticas (Estágio / Júnior)

### ✔ Use `TryParse` em vez de `Parse`

Evita exceções e deixa o código mais seguro.

### ✔ Valide entradas do usuário

Nunca confie que o usuário digitou corretamente.

### ✔ Use métodos para reaproveitar código

Melhora legibilidade e manutenção.

### ✔ Prefira nomes claros

```csharp
bool entradaValida; // bom
bool x;             // ruim
```

### ✔ Evite lógica complexa em uma única condição

Se ficar difícil de ler, refatore.

---

## 4. Próximos Passos

* Condicionais + **laços (`while`, `for`)**
* Tratamento de erros com `try/catch`
* Pequenos **desafios de lógica** (nível entrevista júnior)

Se quiser, posso montar uma **lista de exercícios estilo prova/entrevista** ou um **mini-projeto de console**.
