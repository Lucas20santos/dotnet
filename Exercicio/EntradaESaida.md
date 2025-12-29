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
* Se inválido, peça novamente

🔎 **Validações esperadas**:

* Entrada vazia
* Nome muito curto

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
