# 📝 Exercícios – Entrada e Saída com Validação de Dados (C#)

> 🔔 **Regras gerais para TODOS os exercícios**

* Use `Console.ReadLine()` para entrada
* **NÃO use `Parse` diretamente**
* Use `TryParse`
* Valide entradas vazias (`string.IsNullOrWhiteSpace`)
* Exiba mensagens claras para o usuário

---

## 🟢 Exercício 1 – Nome válido

📌 **Objetivo**: Ler o nome do usuário e validar.

### Requisitos:

* Solicite o nome
* O nome **não pode** estar vazio
* Deve ter pelo menos **3 caracteres**

🔎 **Validações esperadas**:

* Entrada vazia
* Nome muito curto

```csharp
Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine(string.IsNullOrWhiteSpace(nome) || nome.Length < 3 ? "Nome Invalido ou curto demais": nome);
```
---

## 🟢 Exercício 2 – Idade com faixa válida

📌 **Objetivo**: Ler a idade do usuário.

### Requisitos:

* A idade deve ser um número inteiro
* Faixa válida: **0 a 120**
* Enquanto o valor for inválido, continue pedindo

🔎 **Validações esperadas**:

* Texto ao invés de número
* Número negativo
* Número acima de 120

---

```csharp
Console.Write("Digite a sua idade: ");
string entrada = Console.ReadLine();

if (string.IsNullOrWhiteSpace(entrada))
{
    Console.WriteLine("O valor informado para idade não pode ser nullo ou vazio.");
    return;
}

if (!int.TryParse(entrada, out int idade))
{
    Console.WriteLine("Valor informado não é um numero interio.");
    return;
}

if (idade < 0 || idade > 120)
{
    Console.WriteLine($"A idade {idade} fora do range [0:120].");
}
else
{
    Console.WriteLine($"A sua idade é {idade}.");
}
```

## 🟢 Exercício 3 – Média de notas segura

📌 **Objetivo**: Calcular a média de duas notas.

### Requisitos:

* Ler duas notas `double`
* Cada nota deve estar entre **0 e 10**
* Se qualquer nota for inválida, peça novamente
* Exibir a média final

🔎 **Validações esperadas**:

* Texto inválido
* Número fora da faixa

---

```csharp
Console.Write("Digite a primeira nota: ");
string? entrada1 = Console.ReadLine();

if (string.IsNullOrWhiteSpace(entrada1))
{
    Console.WriteLine("Valor não pode ser vazio ou nullo.");
    return;
}

if (!double.TryParse(entrada1, out double nota1))
{
    Console.WriteLine("A nota informada não é um valor valido.");
    return;
}

if (0 > nota1 || nota1 > 10)
{
    Console.WriteLine("Nota Digitada fora do range de [0 à 10].");
    return;
}

Console.Write("Digite a segunda nota: ");
string? entrada2 = Console.ReadLine();

if (string.IsNullOrWhiteSpace(entrada2))
{
    Console.WriteLine("Valor não pode ser vazio ou nullo.");
    return;
}

if (!double.TryParse(entrada2, out double nota2))
{
    Console.WriteLine("A nota informada não é um valor valido.");
    return;
}

if (0 > nota2 || nota2 > 10)
{
    Console.WriteLine("Nota Digitada fora do range de [0 à 10].");
    return;
}

double media = (nota1 + nota2) / 2;
Console.WriteLine($"A média é {media}");
```

## 🟢 Exercício 4 – Menu de opções

📌 **Objetivo**: Criar um menu simples.

### Requisitos:

* Exiba opções:

  ```
  1 - Cadastrar
  2 - Listar
  0 - Sair
  ```
* Leia a opção do usuário
* Aceite apenas `0`, `1` ou `2`
* Enquanto inválido, exiba mensagem de erro

🔎 **Validações esperadas**:

* Valor não numérico
* Opção fora do menu

---

```csharp
Console.Write("MENU:\n1- Cadastrar\n2 - Listar\n0 - Sair\n");
string entrada = Console.ReadLine();

if (string.IsNullOrWhiteSpace(entrada))
{
    Console.WriteLine("O valor informado não pode ser nullo ou vazio.");
    return;
}

if (!int.TryParse(entrada, out int opcao))
{
    Console.WriteLine("Valor informado não é um numero interio.");
    return;
}

if (opcao < 0 || opcao > 2)
{
    Console.WriteLine($"A opcao precisa está entre 0 - 2");
}
else
{
    if (opcao == 1) Console.WriteLine("Cadastro");
    else if (opcao == 2) Console.WriteLine("Listando");
    else Console.WriteLine("Saindo");
}
```

## 🟢 Exercício 5 – Confirmação (Sim ou Não)

📌 **Objetivo**: Ler uma confirmação do usuário.

### Requisitos:

* Pergunte: “Deseja continuar?”
* Aceite apenas:

  * `S` ou `s`
  * `N` ou `n`
* Continue perguntando até receber um valor válido

🔎 **Validações esperadas**:

* Entrada vazia
* Caracter diferente de S ou N

---

## 🟡 Exercício 6 – Cadastro simples (integração)

📌 **Objetivo**: Criar um mini cadastro.

### Campos:

* Nome (mínimo 3 caracteres)
* Idade (0–120)
* Salário (`double` maior que 0)

### Requisitos:

* Validar cada campo separadamente
* Exibir os dados ao final **somente se tudo for válido**

🔎 **Validações esperadas**:

* Entradas vazias
* Tipos inválidos
* Valores fora da regra

---

## 🟡 Exercício 7 – Leitura até entrada válida (função)

📌 **Objetivo**: Reutilização de código.

### Requisitos:

* Crie um método que:

  * Leia um `int`
  * Só retorne quando o valor for válido
* Use esse método para ler:

  * Idade
  * Quantidade de produtos

🔎 **Validações esperadas**:

* Entrada inválida
* Código duplicado (evitar)

---

## 🔴 Exercício 8 – Validação com mensagens específicas

📌 **Objetivo**: Melhorar a experiência do usuário.

### Requisitos:

* Ao errar:

  * Diga **por que** o valor é inválido
* Exemplo:

  * “O valor não é um número”
  * “O número está fora da faixa permitida”

🔎 **Validações esperadas**:

* Diferenciar tipos de erro

---

## 🧠 Desafio extra (Clean Code)

📌 **Objetivo**: Organização e legibilidade.

### Requisitos:

* Separe:

  * Entrada
  * Validação
  * Saída
* Crie métodos como:

  * `LerIdadeValida()`
  * `LerNotaValida()`
* Não misture lógica com `Console.WriteLine`

---

## 📌 Dicas importantes (não código!)

* Prefira **laços `while`** para validação
* Nunca confie na entrada do usuário
* Mensagens claras = software melhor
* Pense como se fosse uma **API recebendo dados**

---
