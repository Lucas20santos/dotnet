# 🧩 EXERCÍCIOS – Operadores em C#

## 🔹 Nível 1 – Básico (Fundamentos)

### 1️⃣ Operadores Aritméticos

Crie um programa que receba dois números inteiros e exiba:

* soma
* subtração
* multiplicação
* divisão
* resto da divisão

📌 **Objetivo**: fixar `+ - * / %`

### Resolução

```csharp
int primeiroNumero = 7;
int segundoNumero = 2;

int soma = primeiroNumero + segundoNumero;
int subtracao = primeiroNumero - segundoNumero;
int multiplicacao = primeiroNumero * segundoNumero;
int parteInteiraDaDivisao = primeiroNumero / segundoNumero;
int restoDaDivisao = primeiroNumero % segundoNumero;
float divisaoFracionada = (float) primeiroNumero /  segundoNumero;

Console.WriteLine(soma);
Console.WriteLine(subtracao);
Console.WriteLine(multiplicacao);
Console.WriteLine(parteInteiraDaDivisao);
Console.WriteLine(restoDaDivisao);
Console.WriteLine(divisaoFracionada);
```

### Detalhes

O exemplo abaixo gera um erro, já que o float.Parse(string) espera uma string e não uma expressão.

#### Primeira Opção

```csharp
float divisaoFracionada = float.Parse(primeiroNumero /  segundoNumero);
```


---

### 2️⃣ Divisão Inteira vs Real

Considere o código:

```csharp
int a = 7;
int b = 2;
```

* Qual será o resultado de `a / b`?
* Como fazer para obter `3.5`?

📌 **Objetivo**: entender conversão de tipos

#### Segunda Opção

```csharp
float divisaoFracionada = (float) primeiroNumero / segundoNumero;
```

#### Terceira Opção

```csharp
float divisaoFracionada = (float) primeiroNumero / segundoNumero;
```

#### Quarta Opção

```csharp
float divisaoFracionada = Convert.ToSingle(primeiroNumero) / segundoNumero;
```

❓ Por que (float)primeiroNumero / segundoNumero funciona ?

📌 Resposta técnica:

> Em uma operação, o C# promove o tipo mais simples para o mais complexo. Ao converter um operando para float, toda a expressão passa a ser float.

---

### 3️⃣ Incremento e Decremento

Dado o código:

```csharp
int x = 5;
Console.WriteLine(x++);
Console.WriteLine(++x);
```

Explique o valor exibido em cada linha.

📌 **Objetivo**: pós vs pré incremento

---

## 🔹 Nível 2 – Intermediário (Lógica)

### 4️⃣ Comparação de Idade

Crie uma variável `idade` e:

* Exiba `true` se a idade for maior ou igual a 18
* Caso contrário, exiba `false`

📌 **Objetivo**: operadores relacionais

---

### 5️⃣ Operadores Lógicos

Dadas as variáveis:

```csharp
bool temLogin = true;
bool temSenha = false;
```

Escreva uma condição que:

* Permita acesso **apenas se ambos forem verdadeiros**

📌 **Objetivo**: `&&`

---

### 6️⃣ Negação Lógica

Dado:

```csharp
bool estaChovendo = true;
```

Utilize o operador lógico para verificar se **não está chovendo**.

📌 **Objetivo**: `!`

---

## 🔹 Nível 3 – Intermediário / Prático

### 7️⃣ Operador Ternário

Crie um código que:

* Verifique se um número é **par ou ímpar**
* Use **operador ternário**

📌 **Objetivo**: substituir `if/else`

---

### 8️⃣ Coalescência Nula

Dada a variável:

```csharp
string nome = null;
```

* Exiba `"Visitante"` caso `nome` seja `null`

📌 **Objetivo**: `??`

---

### 9️⃣ Acesso Seguro

Crie uma classe `Usuario` com a propriedade `Email`.

* Tente acessar `Email` de forma segura mesmo quando o objeto for `null`

📌 **Objetivo**: `?.`

---

### 🔟 Desafio

Crie um programa que:

* Receba nota1 e nota2
* Calcule a média
* Use operador ternário para exibir:

  * `"Aprovado"` se média ≥ 7
  * `"Reprovado"` caso contrário

📌 **Objetivo**: combinação de operadores

---

# 🎯 QUESTÕES DE ENTREVISTA – Operadores em C#

## 1️⃣ O que são operadores em C#?

📌 **Resposta esperada**:
São símbolos usados para realizar operações sobre valores ou variáveis, como cálculos, comparações, atribuições e operações lógicas.

---

## 2️⃣ Qual a diferença entre `==` e `=`?

📌 **Resposta**:

* `=` → atribuição
* `==` → comparação de igualdade

👉 Erro clássico de iniciantes.

---

## 3️⃣ O que o operador `%` faz?

📌 **Resposta**:
Retorna o resto da divisão inteira. Muito usado para verificar números pares/ímpares.

---

## 4️⃣ Qual a diferença entre `&&` e `&`?

📌 **Resposta**:

* `&&` → curto-circuito (não avalia a segunda condição se a primeira for falsa)
* `&` → avalia ambas sempre

👉 Questão **frequente** em entrevistas.

---

## 5️⃣ Explique pré e pós incremento

📌 **Resposta**:

* `++x` → incrementa **antes** de usar
* `x++` → usa o valor atual e incrementa **depois**

---

## 6️⃣ Quando usar o operador ternário?

📌 **Resposta**:
Quando existe uma condição simples com dois resultados possíveis, substituindo `if/else` para deixar o código mais limpo.

---

## 7️⃣ O que é `NullReferenceException` e como evitar?

📌 **Resposta**:
Ocorre ao acessar membros de um objeto `null`.
Pode ser evitado usando:

* `?.`
* `??`
* validações explícitas

---

## 8️⃣ Qual a diferença entre `is` e `as`?

📌 **Resposta**:

* `is` → verifica tipo e retorna `bool`
* `as` → tenta converter e retorna `null` se falhar

---

## 9️⃣ O operador `??` substitui um `if`?

📌 **Resposta**:
Sim, em casos simples onde queremos um valor padrão quando a variável é `null`.

---

## 🔟 Pegadinha de Entrevista

```csharp
int a = 10;
int b = 0;
bool resultado = b != 0 && a / b > 2;
```

📌 **Pergunta**: Isso gera erro?

✅ **Resposta**:
Não, porque `&&` faz curto-circuito e a segunda expressão não é avaliada.

---

## 🧠 Dica Final para Entrevista

Seja capaz de:

* Explicar **com palavras**
* Dar **exemplo simples**
* Apontar **erro comum**

---
