# Fundamentos de programação em dotnet

## ✅ **1. O que são variáveis?**

Variáveis são **espaços na memória** onde podemos armazenar valores.
Elas possuem:

* **um nome**
* **um tipo**
* **um valor**

Exemplo na vida real:

> Variável é como uma caixa etiquetada. A etiqueta é o *nome*, o tipo diz *o que pode ser guardado*, e o valor é *o que está dentro dela*.

---

## ✅ **2. Tipos de dados em C#**

No C#, os tipos podem ser separados em:

---

## 🔹 **2.1. Tipos numéricos inteiros**

| Tipo    | Tamanho | Exemplo               |
| ------- | ------- | --------------------- |
| `byte`  | 1 byte  | 0 a 255               |
| `short` | 2 bytes | números menores       |
| `int`   | 4 bytes | mais usado            |
| `long`  | 8 bytes | números muito grandes |

### Exemplo

```csharp
int idade = 33;
long populacao = 214000000;
byte nivel = 120;
```

---

## 🔹 **2.2. Tipos numéricos reais (quebrados)**

| Tipo      | Precisão   | Quando usar                     |
| --------- | ---------- | ------------------------------- |
| `float`   | 7 dígitos  | medidas aproximadas             |
| `double`  | 15 dígitos | cálculos gerais                 |
| `decimal` | 28 dígitos | dinheiro e cálculos financeiros |

### Exemplo 2

```csharp
double temperatura = 26.7;
decimal preco = 199.99m;
```

> Note o **m** no final do decimal.

---

## 🔹 **2.3. Tipo `char` (um único caractere)**

```csharp
char letra = 'A';
char simbolo = '#';
```

---

## 🔹 **2.4. Tipo `string` (texto)**

```csharp
string nome = "Lucas";
string frase = "Estudando C#!";
```

---

## 🔹 **2.5. Tipo booleano (`bool`)**

Armazena apenas:

* `true`
* `false`

```csharp
bool logado = true;
bool maiorDeIdade = false;
```

---

## 🔹 **2.6. Tipo `var`**

Tipo inferido pelo compilador (não muda depois!):

```csharp
var idade = 33;       // vira int
var nome = "Lucas";   // vira string
```

---

### ✅ **3. Regras para nomes de variáveis**

✔ Podem começar com letra ou _
✔ Podem conter números
✔ Não podem ter espaço
✔ Não podem começar com número
✔ Evite nomes ruins

Exemplo ruim:

```cs
int a = 10;
```

Exemplo bom:

```cs
int quantidadeProdutos = 10;
```

---

### ✅ **4. Exemplos completos**

#### 🔸 Exemplo 1: Declaração e impressão

```csharp
int idade = 33;
string nome = "Lucas";
bool aprovado = true;
```

#### 🔸 Exemplo 2: Reatribuição

```csharp
int contador = 1;
contador = 2; // ok
```

#### 🔸 Exemplo 3: Erro comum

❌ NÃO PODE:

```csharp
int numero = "texto";
```

---

#### 🧠 **5. Exercícios (sem código pronto)**

Você deve **pensar e escrever o código**.
Eu posso corrigir depois!

---

### ✅ **Exercício 1 – Crie variáveis simples**

Crie variáveis para guardar:

1. Seu nome
2. Sua idade
3. Sua altura
4. Se você está estudando C# (bool)

---

### ✅ **Exercício 2 – Trabalhando com números**

Crie três variáveis:

* um inteiro
* um double
* um decimal

Depois escreva uma frase usando elas.
Exemplo: "O valor total é ..."

---

### ✅ **Exercício 3 – Tipos e conversões**

Crie:

* uma variável int
* uma variável string contendo um número
* converta a string para int
* some os valores

---

### ✅ **Exercício 4 – Char e String**

Crie um char com sua inicial e uma string com seu nome completo.
Depois exiba ambos juntos.

---

### ✅ **Exercício 5 – Declare e reatribua**

Crie uma variável double com um valor inicial.
Depois mude seu valor duas vezes.

---

### ✅ **Exercício 6 – Use var**

Declare 4 variáveis usando `var`:

* uma string
* um int
* um bool
* um double

Depois verifique se o compilador inferiu o tipo corretamente.

---

### ✅ **Exercício 7 – Valide nomes de variáveis**

Diga quais destes nomes são válidos e por quê:

1. `1numero`
2. `_resultado`
3. `nome-completo`
4. `precoFinal`
5. `double`

---
