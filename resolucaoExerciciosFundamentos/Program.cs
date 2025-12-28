// Fundamentos de Programação com dotnet csharp
// Exercício 01

// int primeiroNumero = 7;
// int segundoNumero = 2;

// int soma = primeiroNumero + segundoNumero;
// int subtracao = primeiroNumero - segundoNumero;
// int multiplicacao = primeiroNumero * segundoNumero;
// int parteInteiraDaDivisao = primeiroNumero / segundoNumero;
// int restoDaDivisao = primeiroNumero % segundoNumero;
// float divisaoFracionada = (float) primeiroNumero /  segundoNumero;


// Console.WriteLine(soma);
// Console.WriteLine(subtracao);
// Console.WriteLine(multiplicacao);
// Console.WriteLine(parteInteiraDaDivisao);
// Console.WriteLine(restoDaDivisao);

// Exercício 02

// float divisaoFracionada = Convert.ToSingle(primeiroNumero ) /  segundoNumero;
// Console.WriteLine(divisaoFracionada);

// Exercício 03

// Aplicando o pós-incremento

int x = 5;
// Console.WriteLine(x++);

// Aplicando o pré-incremento

int y = 9;
// Console.WriteLine(++y);

int z = x++ + ++y;

// Na expressão acima, 'x' contribui com o valor 5 e só depois é incrementado
// Já 'y' sofre o incremento antes e contribui com o valor 10
Console.WriteLine(z); // 15

// Exercício 04

int idade = 20;

bool ehMaiorDeIdade = idade >= 18;

Console.WriteLine(ehMaiorDeIdade);

// Exercício 05

bool temLogin = true;
bool temSenha = false;

bool temAcesso = temLogin && temSenha;

Console.WriteLine("Usuario tem acesso: " + temAcesso);

// Exercício 06

bool estaChovendo = true;

string mensagemNaoEstaChovendo = !estaChovendo ? "Nao Está chovendo!" : "Ainda Está Chovendo!";

Console.WriteLine("Situação climática: " + mensagemNaoEstaChovendo);


// Exercicio 07

int numero = 20;
string ehPar = numero % 2 == 0 ? $"O Número {numero} é Par!": $"O Número {numero} é Impar!";
Console.WriteLine(ehPar);
