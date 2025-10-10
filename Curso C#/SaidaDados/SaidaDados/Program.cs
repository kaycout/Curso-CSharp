// Diferença de PLaceholders, concatenação e interpolação.

using System;
using System.Globalization;

int idade = 18;
double saldo = 50.2345;
string nome = "Maria";

// Para imprimir as informações que
// contém dentro das variáveis em uma única frase
// com Placeholder.

Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

// {2:F2} - Para separar a quantidade de casas decimais.

// Para imprimir informações com Interpolação.

Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

// Para imprimir informações com Concatenação.

Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");