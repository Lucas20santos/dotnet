# 🧩 MINI-PROJETO: **Sistema de Controle de Notas**

## 🎯 Objetivo

Criar um programa de console que permita ao usuário **cadastrar notas**, **validar entradas**, **calcular média** e **mostrar a situação final** do aluno, usando estruturas básicas do C#.

---

## 📌 Funcionalidades obrigatórias

### 1️⃣ Menu interativo (Entrada e Saída + Loops)

O programa deve exibir um menu que se repete até o usuário escolher sair:

```
1 - Inserir nota
2 - Calcular média
3 - Mostrar situação
0 - Sair
```

➡️ O menu deve continuar rodando até o usuário escolher **0**.

---

### 2️⃣ Variáveis

Você deverá trabalhar com:

* Uma **lista de notas** (`List<double>`)
* Variáveis para:

  * opção do menu
  * média
  * situação (Aprovado / Recuperação / Reprovado)

---

### 3️⃣ Validações (parte mais importante)

Sempre validar:

* Entrada nula ou vazia
* Conversão numérica (`TryParse`)
* Nota deve estar **entre 0 e 10**
* Não permitir calcular média sem notas cadastradas

📌 Nenhuma entrada inválida deve quebrar o programa.

---

### 4️⃣ Condicionais

A situação do aluno deve seguir a regra:

| Média     | Situação    |
| --------- | ----------- |
| ≥ 7       | Aprovado    |
| ≥ 5 e < 7 | Recuperação |
| < 5       | Reprovado   |

Use `if / else` ou `switch`.

---

### 5️⃣ Loops

Você deverá usar:

* `while` → para o menu
* `foreach` ou `for` → para percorrer as notas

---

## 🧠 Fluxo esperado do programa

1. Exibe o menu
2. Usuário escolhe uma opção
3. Programa valida a opção
4. Executa a ação escolhida
5. Retorna ao menu

---

## 🔒 Regras do projeto

* ❌ Não pode usar exceções para controle de fluxo
* ✅ Deve usar `TryParse`
* ✅ Deve usar `List`
* ✅ Deve usar `continue` e `break` conscientemente
* ❌ Não pode acessar índice sem validar

---

## ⭐ Desafios extras (opcional)

Se quiser subir o nível:

* Mostrar a **maior** e **menor** nota
* Limpar a lista de notas
* Permitir remover uma nota pelo índice
* Usar **métodos** para organizar o código

Exemplos de métodos (conceito):

```csharp
static double LerNota()
static double CalcularMedia(List<double> notas)
static string ObterSituacao(double media)
```

---

## 📈 O que esse mini-projeto avalia

✔️ Lógica de programação
✔️ Fundamentos do C#
✔️ Escrita defensiva
✔️ Organização de código
✔️ Pensamento de desenvolvedor júnior

---
