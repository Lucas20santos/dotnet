# 🧪 **Guia Completo de Estudos — Testes em .NET (xUnit, MSTest, NUnit)**

> 🔥 *Domine testes automatizados no .NET e aprenda a escrever código sólido, limpo e confiável.*

---

## 🟦 **Fundamentos de Testes**

* O que são testes automatizados
* Tipos de testes (Unitário, Integração, Funcional, End-to-End)
* Pirâmide de testes
* Falso negativo x falso positivo
* Boa prática: “teste deve falhar antes de funcionar”

---

## 🧪 **Testes Unitários**

* Criar projeto de testes (`xUnit`, `MSTest` ou `NUnit`)
* Estrutura AAA (Arrange – Act – Assert)
* Asserts mais importantes
* Testes parametrizados
* Testes com exceções
* Testes isolados (sem dependências externas)

---

## 🧱 **Principais Frameworks de Teste**

### ✔ **xUnit** (mais usado no mercado)

* `[Fact]`
* `[Theory]` + `InlineData`
* Setup com `IClassFixture`
* Assert.Throws
* Assert.Collection / Assert.Contains
* Organização de testes em classes e namespaces

### ✔ **MSTest**

* `[TestClass]`
* `[TestMethod]`
* `[DataTestMethod]`
* `[DataRow]`
* Métodos Setup: `TestInitialize` e `TestCleanup`

### ✔ **NUnit**

* `[Test]`
* `[TestCase]`
* `[SetUp]`
* `[TearDown]`

---

## 🧿 **Mocks e Stubs**

Essencial para testar classes com dependências.

* Quando usar mocks
* Quando usar stubs
* Evitar mocks excessivos
* Introdução ao framework **Moq**
* Configurar `Setup()`
* Verificar comportamento com `Verify()`
* Mockar serviços externos, repositórios, APIs, autenticação, logs etc.

---

## 🔧 **Testes de Integração**

* A diferença entre teste unitário e integração
* Testar banco real (SQLite InMemory, SQL Server, Postgre...)
* Testar controllers e endpoints
* Testes com `WebApplicationFactory`
* Testar o pipeline real da API
* Testes envolvendo EF Core (muito usado no mercado)

---

## 🌐 **Testes de API (Minimal API / MVC)**

* Testar GET, POST, PUT e DELETE
* Validar status code
* Validar body da resposta
* Mockar serviços dentro dos controllers
* Testar endpoints com autenticação JWT
* Testes com `HttpClient` real (integração)

---

## 🧰 **Ferramentas essenciais**

* `dotnet test`
* `coverlet` para medir cobertura
* `ReportGenerator` para gerar relatório HTML
* Test Explorer do VS Code ou Rider
* Pipeline automatizado com GitHub Actions

---

## 🧩 **Boas práticas**

* Testes independentes
* Nomes descritivos
* Nunca repetir código
* Evitar testar implementação, testar comportamento
* Cobertura ideal ~70%, sem obsessão por 100%
* Mock só quando necessário
* Testes rápidos e legíveis

---

# 📅 **Mapa de Estudos – Testes em .NET (30 Dias)**

## 📘 **Semana 1 — Fundamentos**

1. O que são testes
1. Tipos de testes
1. Criar primeiro projeto xUnit
1. AAA (Arrange, Act, Assert)
1. Testes com diferentes asserts

## 📘 **Semana 2 — Profissionalizando**

1. Testes parametrizados
1. Testes de exceções
1. Introdução a Mocks
1. Moq: Setup básico
1. Moq: Verify e comportamentos

## 📘 **Semana 3 — Integração e APIs**

1. Testes de integração
1. Testes com banco InMemory
1. Testar Controllers
1. WebApplicationFactory
1. Testar APIs com autenticação

## 📘 **Semana 4 — Consolidação**

1. Criar projeto real com testes
1. Implementar cobertura de código
1. Relatórios com Coverlet + ReportGenerator
1. Subir testes para CI/CD
1. Projeto final: testar uma API completa com mock e integração

---

## 💠 **Versão para colocar no seu README**

### 🧪 Testes em .NET — Roadmap Completo

Este guia reúne tudo o que estudei e continuo evoluindo sobre **testes unitários, de integração e APIs no .NET**, incluindo xUnit, MSTest, NUnit e Moq.

---

## 📌 O que estudo e domino em Testes

* Testes Unitários (AAA, asserts, exceptions)
* Testes Parametrizados
* Mocks com Moq
* Testes de Integração
* Testes de API
* Testes com banco InMemory
* WebApplicationFactory
* Cobertura de testes
* Relatórios de cobertura
* Automatização com GitHub Actions

---

## 📅 Roadmap de 30 dias (Testes .NET)

* **Semana 1:** Fundamentos e testes unitários
* **Semana 2:** Testes avançados, mocks, Moq
* **Semana 3:** Testes de Integração + API
* **Semana 4:** Cobertura, CI/CD, projeto final

---
