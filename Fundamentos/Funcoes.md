# Funções em C# (Métodos)

Este material apresenta **tudo o que você precisa saber sobre funções em C#** (chamadas oficialmente de **métodos**), com explicações claras e **exemplos progressivos**, no mesmo estilo dos materiais anteriores.

---

## 1. O que é uma Função (Método)?

Uma função é um **bloco de código reutilizável** que executa uma tarefa específica.

👉 Em C#, funções são chamadas de **métodos** e **sempre pertencem a uma classe**.

**Vantagens:**

* Reutilização de código
* Organização
* Facilidade de manutenção
* Código mais legível

---

## 2. Estrutura Básica de uma Função

```csharp
modificador tipoRetorno NomeDaFuncao(parametros)
{
    // corpo da função
}
```

### Exemplo simples

```csharp
static void Saudacao()
{
    Console.WriteLine("Olá, bem-vindo ao C#!");
}
```

📌 `void` significa que a função **não retorna valor**.

---

## 3. Chamando (Invocando) uma Função

```csharp
Saudacao();
```

🔹 A função só executa quando é chamada.

---

## 4. Funções com Parâmetros

Parâmetros permitem **enviar dados** para a função.

### Exemplo:

```csharp
static void MostrarMensagem(string nome)
{
    Console.WriteLine($"Olá, {nome}!");
}
```

Chamada:

```csharp
MostrarMensagem("Lucas");
```

---

## 5. Funções com Retorno

Funções podem **retornar valores** usando `return`.

### Exemplo 1

```csharp
static int Somar(int a, int b)
{
    return a + b;
}
```

Uso:

```csharp
int resultado = Somar(5, 3);
Console.WriteLine(resultado);
```

📌 O tipo do `return` deve ser o mesmo do tipo declarado na função.

---

## 6. Função com Parâmetros + Retorno

```csharp
static double CalcularMedia(double n1, double n2)
{
    return (n1 + n2) / 2;
}
```

```csharp
double media = CalcularMedia(8, 7);
Console.WriteLine(media);
```

---

## 7. Funções com Tipos Nullable

```csharp
static double CalcularMedia(double? n1, double? n2)
{
    return ((n1 ?? 0) + (n2 ?? 0)) / 2;
}
```

📌 Uso do operador **coalescente nulo (`??`)**.

---

## 8. Funções com Validação (Boas Práticas)

```csharp
static bool EhNumeroValido(string entrada)
{
    return int.TryParse(entrada, out _);
}
```

```csharp
if (EhNumeroValido("10"))
{
    Console.WriteLine("Número válido");
}
```

### 1. Entendendo o `out`

Normalmente, você usaria assim:

```csharp
bool sucesso = int.TryParse(entrada, out int numero);
```

* `sucesso` → indica se deu certo
* `numero` → valor convertido

---

### 1. O que significa `out _` ?

```csharp
out _
```

👉 O `_` é chamado de **discard** (descartar valor).

Ou seja:

* Você **não precisa do número convertido**
* Só quer saber **se é válido ou não**

💡 Então você diz ao C#:

> “Tente converter, mas não me interessa o valor final.”

---

## 9. Funções com `out`

Usadas para retornar **mais de um valor**.

```csharp
static bool TentarConverter(string texto, out int numero)
{
    return int.TryParse(texto, out numero);
}
```

```csharp
if (TentarConverter("20", out int n))
{
    Console.WriteLine(n);
}
```

---

## 10. Funções com Parâmetros Opcionais

```csharp
static void ExibirMensagem(string mensagem = "Olá!")
{
    Console.WriteLine(mensagem);
}
```

```csharp
ExibirMensagem();
ExibirMensagem("Bem-vindo!");
```

---

## 11. Funções com `params`

Permite passar vários valores.

```csharp
static int SomarTudo(params int[] numeros)
{
    int soma = 0;
    foreach (int n in numeros)
        soma += n;

    return soma;
}
```

```csharp
int total = SomarTudo(1, 2, 3, 4);
```

---

## 12. Escopo de Variáveis

```csharp
static void Exemplo()
{
    int x = 10; // visível apenas aqui
}
```

📌 Variáveis criadas dentro da função **não existem fora dela**.

---

## 13. Funções Estáticas (`static`)

* Pertencem à classe
* Não precisam de instância

```csharp
static void Main()
{
    Saudacao();
}
```

---

## 14. Boas Práticas com Funções

✔ Nome claro e objetivo
✔ Uma função = uma responsabilidade
✔ Evitar funções longas
✔ Evitar efeitos colaterais
✔ Validar entradas

---

## 15. Exemplo Completo (Mini Projeto)

```csharp
static double LerNota()
{
    while (true)
    {
        Console.Write("Digite a nota: ");
        string entrada = Console.ReadLine();

        if (double.TryParse(entrada, out double nota))
            return nota;

        Console.WriteLine("Valor inválido!");
    }
}

static void Main()
{
    double n1 = LerNota();
    double n2 = LerNota();

    double media = CalcularMedia(n1, n2);
    Console.WriteLine($"Média: {media}");
}
```

---

## 16. Resumo Rápido

* Funções organizam o código
* Podem receber parâmetros
* Podem retornar valores
* Ajudam na reutilização
* Melhoram a legibilidade

---

📌 **Próximo passo sugerido:**

* Exercícios práticos com funções
* Funções vs Métodos em POO
* Funções recursivas
