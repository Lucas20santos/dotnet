# 🧠 Lista de Exercícios – Funções em C# (Métodos)

Esta lista foi criada para **fixar TODOS os conceitos de funções** que você estudou até agora. Os exercícios estão organizados do **mais simples ao mais completo**, seguindo boas práticas.

📌 **Regras gerais**:

* Use `static`
* Use nomes claros
* Não escreva tudo no `Main`
* Cada função deve ter **uma responsabilidade**

---

## 🟢 NÍVEL 1 — Fundamentos

### 1️⃣ Função sem parâmetros e sem retorno

Crie uma função que exiba a mensagem:

> "Bem-vindo ao estudo de funções em C#"

---

### 2️⃣ Função com parâmetro (string)

Crie uma função que receba um nome e exiba:

> "Olá, {nome}!"

---

### 3️⃣ Função com retorno `int`

Crie uma função que receba dois números inteiros e retorne a soma deles.

---

### 4️⃣ Função com retorno `bool`

Crie uma função que receba um número inteiro e retorne `true` se ele for **par**, ou `false` caso contrário.

---

## 🟡 NÍVEL 2 — Parâmetros, Retorno e Validação

### 5️⃣ Função com `TryParse`

Crie uma função que receba uma `string` e retorne `true` se ela puder ser convertida para `int`.

---

### 6️⃣ Função com `out`

Crie uma função que tente converter uma `string` em `int`.

* Retorne `true` ou `false`
* Use `out` para retornar o número convertido

---

### 7️⃣ Função com validação de entrada

Crie uma função que receba uma nota (`double`) e:

* Retorne `true` se estiver entre 0 e 10
* Retorne `false` caso contrário

---

### 8️⃣ Função que lê número do usuário

Crie uma função que:

* Leia um número do console
* Valide usando `TryParse`
* Continue pedindo até o valor ser válido
* Retorne o número

---

## 🟠 NÍVEL 3 — Nullable, Opcionais e Params

### 9️⃣ Função com parâmetros nullable

Crie uma função que receba duas notas `double?` e retorne a média.

* Use o operador `??`

---

### 🔟 Função com parâmetro opcional

Crie uma função que exiba uma mensagem.

* Se nenhuma mensagem for passada, exiba: "Olá!"

---

### 1️⃣1️⃣ Função com `params`

Crie uma função que receba vários números inteiros e retorne a soma deles.

---

### 1️⃣2️⃣ Função com `params` + validação

Crie uma função que receba vários números e retorne:

* A soma
* A média

(Dica: reaproveite funções já criadas)

---

## 🔵 NÍVEL 4 — Organização e Boas Práticas

### 1️⃣3️⃣ Refatoração

Dado um código todo dentro do `Main`, refatore criando funções para:

* Ler número
* Calcular média
* Mostrar resultado

---

### 1️⃣4️⃣ Função pequena e objetiva

Crie uma função que:

* Receba uma idade
* Retorne `true` se for maior ou igual a 18

---

### 1️⃣5️⃣ Funções encadeadas

Crie funções para:

* Ler duas notas
* Calcular média
* Retornar situação (Aprovado/Reprovado)

O `Main` deve apenas **orquestrar** as chamadas.

---

## 🔴 DESAFIO FINAL (Mini Projeto)

### 🏆 Sistema de Notas

Crie um programa usando funções para:

* Exibir menu
* Ler opção do usuário
* Inserir notas em uma lista
* Calcular média
* Exibir situação final
* Validar todas as entradas

📌 Regras:

* Nenhuma lógica pesada no `Main`
* Use `TryParse`
* Use funções pequenas

---

## ✅ Checklist de Conceitos Usados

✔ Funções `void`
✔ Funções com retorno
✔ Parâmetros
✔ `TryParse`
✔ `out`
✔ Nullable (`?`)
✔ `??`
✔ `params`
✔ Parâmetros opcionais
✔ Boas práticas
✔ Organização do código

---

📌 **Quando terminar**:

* Me envie um ou dois exercícios resolvidos
* Eu reviso, corrijo e sugiro melhorias (sem escrever o código por você 😉)
