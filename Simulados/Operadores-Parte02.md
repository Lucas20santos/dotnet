# 🧪 SIMULADO PRÁTICO – OPERADORES EM C#

⏱ **Tempo sugerido:** 60 minutos
📌 **Nível:** Júnior / Júnior+
🛠 **Linguagem:** C# (.NET)

---

## 📌 REGRAS DA PROVA

* Não usar LINQ
* Não usar bibliotecas externas
* Pode usar `Console.WriteLine`
* Código deve ser claro e legível

---

## 🧩 QUESTÃO 1 – Cálculos Básicos (10 pts)

Crie um método que:

* Receba dois números inteiros
* Retorne:

  * soma
  * subtração
  * multiplicação
  * divisão
  * resto da divisão

📌 **Critérios avaliados**:

* Uso correto de operadores aritméticos
* Tratamento de divisão por zero

---

## 🧩 QUESTÃO 2 – Validação de Acesso (10 pts)

Crie um método que receba:

```csharp
bool temUsuario
bool temSenha
bool estaAtivo
```

O acesso só deve ser permitido se:

* `temUsuario` **e**
* `temSenha` **e**
* `estaAtivo`

📌 Exibir:

* `"Acesso permitido"`
* `"Acesso negado"`

📌 **Critérios avaliados**:

* Uso de operadores lógicos
* Clareza da condição

---

## 🧩 QUESTÃO 3 – Classificação Numérica (10 pts)

Crie um método que receba um número inteiro e:

* Informe se é:

  * positivo
  * negativo
  * zero

📌 **Critérios avaliados**:

* Uso de operadores relacionais
* Estrutura condicional correta

---

## 🧩 QUESTÃO 4 – Par ou Ímpar (10 pts)

Crie um método que:

* Receba um número inteiro
* Retorne `"Par"` ou `"Ímpar"`
* **Obrigatório** usar operador ternário

📌 **Critérios avaliados**:

* Uso correto de `%`
* Uso do operador ternário

---

## 🧩 QUESTÃO 5 – Tratamento de Null (10 pts)

Crie uma classe:

```csharp
class Cliente
{
    public string Nome { get; set; }
}
```

Crie um método que:

* Receba um objeto `Cliente`
* Exiba o nome
* Caso seja `null`, exiba `"Cliente não informado"`

📌 **Obrigatório**:

* Usar `?.` ou `??`

---

## 🧩 QUESTÃO 6 – Incremento em Loop (10 pts)

Crie um método que:

* Use um `for`
* Conte de 1 até 10
* Mostre o valor atual usando **pré e pós incremento**
* Explique a diferença em comentário

📌 **Critérios avaliados**:

* Uso correto de `++`
* Entendimento conceitual

---

## 🧩 QUESTÃO 7 – Segurança contra Erros (10 pts)

Crie um método que:

* Receba dois inteiros `a` e `b`
* Só faça a divisão se `b` for diferente de zero
* Use operador lógico para evitar exceção

📌 **Obrigatório**:

* Usar curto-circuito (`&&`)

---

## 🧩 QUESTÃO 8 – Desafio Final (20 pts)

Crie um método que:

* Receba:

  * `nota1`
  * `nota2`
* Calcule a média
* Retorne:

  * `"Aprovado"` se média ≥ 7
  * `"Recuperação"` se média ≥ 5 e < 7
  * `"Reprovado"` se média < 5

📌 **Obrigatório**:

* Uso de operadores relacionais
* Pode usar **if/else ou ternário aninhado**

---

# 🧠 AVALIAÇÃO FINAL (100 pts)

| Critério                  | Pontos |
| ------------------------- | ------ |
| Correção lógica           | 40     |
| Uso correto de operadores | 30     |
| Legibilidade              | 20     |
| Boas práticas             | 10     |

---

## 🎯 NÍVEL ESPERADO

* **≤ 60 pts** → revisar fundamentos
* **61–80 pts** → júnior consistente
* **81–100 pts** → pronto para vaga 🚀

---
