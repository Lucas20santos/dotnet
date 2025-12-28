# 📝 SIMULADO TÉCNICO – OPERADORES EM C#

⏱ **Tempo sugerido:** 30–40 minutos
📌 **Nível:** Júnior / Júnior+
🎯 **Objetivo:** Avaliar domínio prático e conceitual dos operadores em C#

---

## 🔹 PARTE 1 – Múltipla Escolha (1 ponto cada)

### 1️⃣ Qual será a saída do código abaixo?

```csharp
int a = 10;
int b = 3;
Console.WriteLine(a / b);
```

A) 3.33
B) 3
C) 3.0
D) Erro de compilação

---

### 2️⃣ Qual operador é usado para verificar igualdade?

A) `=`
B) `!=`
C) `==`
D) `===`

---

### 3️⃣ O que o operador `%` retorna?

A) O quociente da divisão
B) O resto da divisão
C) Um valor booleano
D) Um valor decimal

---

### 4️⃣ Qual alternativa **evita NullReferenceException**?

A) `obj.Property`
B) `obj!.Property`
C) `obj?.Property`
D) `obj == Property`

---

### 5️⃣ Qual a diferença principal entre `&&` e `&`?

A) Não há diferença
B) `&&` é mais rápido
C) `&&` faz curto-circuito
D) `&` só funciona com booleanos

---

## 🔹 PARTE 2 – Verdadeiro ou Falso (1 ponto cada)

### 6️⃣ ( ) O operador `++x` incrementa a variável antes de seu uso

### 7️⃣ ( ) O operador ternário substitui qualquer `if`

### 8️⃣ ( ) O operador `??` é usado para tratar valores nulos

### 9️⃣ ( ) `==` compara referências em todos os casos

### 🔟 ( ) Operadores relacionais retornam `bool`

---

## 🔹 PARTE 3 – Análise de Código (2 pontos cada)

### 1️⃣1️⃣ Qual será a saída?

```csharp
int x = 5;
int y = x++ + ++x;
Console.WriteLine(y);
```

Explique brevemente.

---

### 1️⃣2️⃣ O código abaixo gera erro? Por quê?

```csharp
int a = 10;
int b = 0;

if (b != 0 && a / b > 2)
{
    Console.WriteLine("OK");
}
```

---

## 🔹 PARTE 4 – Complete o Código (2 pontos cada)

### 1️⃣3️⃣ Complete usando **operador ternário**:

```csharp
int numero = 7;
string resultado = ____________________;
```

📌 Deve exibir `"Par"` ou `"Ímpar"`

---

### 1️⃣4️⃣ Complete usando **coalescência nula**:

```csharp
string nome = null;
string exibicao = ____________________;
```

📌 Valor padrão: `"Usuário"`

---

## 🔹 PARTE 5 – Questão Discursiva (4 pontos)

### 1️⃣5️⃣ Explique:

* O que são operadores em C#
* Cite **3 tipos diferentes**
* Dê **um exemplo prático** de uso real

---

---

# ✅ GABARITO COMENTADO

## 🔹 Parte 1

1️⃣ **B** – divisão inteira
2️⃣ **C**
3️⃣ **B**
4️⃣ **C**
5️⃣ **C**

---

## 🔹 Parte 2

6️⃣ **V**
7️⃣ **F** (nem todo `if` pode ser substituído)
8️⃣ **V**
9️⃣ **F** (`==` pode comparar valores)
🔟 **V**

---

## 🔹 Parte 3

### 1️⃣1️⃣

```text
x = 5
x++ → usa 5, depois vira 6
++x → vira 7
y = 5 + 7 = 12
```

✅ Saída: **12**

---

### 1️⃣2️⃣

✅ **Não gera erro**, pois `&&` faz curto-circuito e `a / b` não é avaliado.

---

## 🔹 Parte 4

### 1️⃣3️⃣

```csharp
string resultado = numero % 2 == 0 ? "Par" : "Ímpar";
```

---

### 1️⃣4️⃣

```csharp
string exibicao = nome ?? "Usuário";
```

---

## 🔹 Parte 5 – Resposta Esperada (resumo)

* Operadores realizam operações sobre valores
* Tipos: aritméticos, lógicos, relacionais
* Exemplo: validar login com `&&`, tratar null com `??`

---

## 🎯 Avaliação

* **0–10** → revisar fundamentos
* **11–18** → nível júnior sólido
* **19–25** → pronto para entrevista técnica 🚀

---
