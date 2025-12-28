# 📘 Operadores em C# (CSharp)

Operadores são **símbolos que executam operações sobre valores ou variáveis**, como cálculos, comparações, atribuições e operações lógicas.

---

## 1️⃣ Operadores Aritméticos

Usados para **operações matemáticas básicas**.

| Operador | Descrição      | Exemplo |
| -------- | -------------- | ------- |
| `+`      | Soma           | `a + b` |
| `-`      | Subtração      | `a - b` |
| `*`      | Multiplicação  | `a * b` |
| `/`      | Divisão        | `a / b` |
| `%`      | Módulo (resto) | `a % b` |

### 🔹 Exemplo

```csharp
int a = 10;
int b = 3;

Console.WriteLine(a + b); // 13
Console.WriteLine(a - b); // 7
Console.WriteLine(a * b); // 30
Console.WriteLine(a / b); // 3
Console.WriteLine(a % b); // 1
```

⚠️ **Atenção**: divisão entre inteiros retorna inteiro.

```csharp
double resultado = (double)a / b; // 3.333...
```

---

## 2️⃣ Operadores de Atribuição

Usados para **atribuir valores a variáveis**.

| Operador | Exemplo  | Equivale a  |
| -------- | -------- | ----------- |
| `=`      | `a = 5`  | —           |
| `+=`     | `a += 2` | `a = a + 2` |
| `-=`     | `a -= 2` | `a = a - 2` |
| `*=`     | `a *= 2` | `a = a * 2` |
| `/=`     | `a /= 2` | `a = a / 2` |

### 🔹 Exemplo

```csharp
int x = 10;

x += 5;  // 15
x -= 3;  // 12
x *= 2;  // 24
x /= 4;  // 6
```

---

## 3️⃣ Operadores de Comparação (Relacionais)

Usados para **comparar valores**. Sempre retornam `bool`.

| Operador | Descrição      |
| -------- | -------------- |
| `==`     | Igual          |
| `!=`     | Diferente      |
| `>`      | Maior          |
| `<`      | Menor          |
| `>=`     | Maior ou igual |
| `<=`     | Menor ou igual |

### 🔹 Exemplo

```csharp
int idade = 18;

Console.WriteLine(idade >= 18); // true
Console.WriteLine(idade <= 20); // true
Console.WriteLine(idade == 20); // false
Console.WriteLine(idade > 20);  // false
Console.WriteLine(idade < 20);  // true
Console.WriteLine(idade != 20); // true
```

---

## 4️⃣ Operadores Lógicos

Usados para **combinar expressões booleanas**.

| Operador | Significado |
| -------- | ----------- |
| `&&`     | E (AND)     |
| `\|\|`   | Ou (OR)     |
| `!`      | Negação     |

### 🔹 Exemplo

```csharp
bool temCarteira = true;
bool maiorDeIdade = true;

bool expressaoBooleano = temCarteira && maiorDeIdade // true

Console.WriteLine("Pode dirigir" + expressaoBoolena);
```

```csharp
bool chovendo = false;

Console.WriteLine("Pode sair sem guarda-chuva? " + !chovendo);

```

---

## 5️⃣ Operadores de Incremento e Decremento

Usados para **aumentar ou diminuir valores em 1**.

| Operador | Descrição  |
| -------- | ---------- |
| `++`     | Incrementa |
| `--`     | Decrementa |

### 🔹 Exemplo

```csharp
int contador = 0;

contador++; // 1
contador--; // 0
```

### 🔹 Pré x Pós incremento

```csharp
int a = 5;

Console.WriteLine(a++); // 5
Console.WriteLine(a);   // 6

Console.WriteLine(++a); // 7
```

---

## 6️⃣ Operador Ternário

Forma **curta de um if/else**.

### 🔹 Sintaxe

```csharp
condicao ? valorSeVerdadeiro : valorSeFalso;
```

### 🔹 Exemplo

```csharp
int idade = 16;

string status = idade >= 18 ? "Maior de idade" : "Menor de idade";
Console.WriteLine(status);
```

---

## 7️⃣ Operadores de Tipo

### 🔹 `is` – Verifica tipo

```csharp
object valor = "Olá";

if (valor is string)
{
    Console.WriteLine("É uma string");
}
```

### 🔹 `as` – Conversão segura

```csharp
object texto = "C#";

string resultado = texto as string;
```

---

## 8️⃣ Operador de Coalescência Nula (`??`)

Usado para **definir valor padrão se for `null`**.

```csharp
string nome = null;

string resultado = nome ?? "Usuário padrão";
Console.WriteLine(resultado);
```

---

## 9️⃣ Operador de Acesso Seguro (`?.`)

Evita `NullReferenceException`.

```csharp
Pessoa pessoa = null;

string nome = pessoa?.Nome;
```

---

## 🧠 Resumo Rápido

* Operadores **aritméticos** → cálculo
* Operadores **lógicos** → decisões
* Operadores **relacionais** → comparações
* Operadores **ternários** → if compacto
* Operadores **nulos** → código mais seguro

---

## [Exercicios]()
