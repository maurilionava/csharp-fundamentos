/*
*   Calculadora Básica Simples:
*   Crie um programa que solicite dois números inteiros ao usuário.
*   Implemente as quatro operações básicas (soma, subtração, multiplicação e divisão) e exiba os resultados.
*   Conceitos chave: Top-Level Statements (se estiver usando C# moderno), I/O (System.Console), Tipos de Valor (int), Operadores.
*/
public class Calculadora
{
    public void Calcular()
    {
        System.Console.WriteLine($"### PROJETO CALCULADORA ###");

        System.Console.WriteLine($"INFORME O PRIMEIRO NÚMERO INTEIRO:");
        var num1 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine($"INFORME O SEGUNDO NÚMERO INTEIRO:");
        var num2 = Convert.ToInt32(Console.ReadLine());

        var soma = num1 + num2;
        var subtracao = num1 - num2;
        var multiplicacao = num1 * num2;
        var divisao = num1 / num2;

        System.Console.WriteLine($"RESULTADOS:");
        System.Console.WriteLine($"{num1} + {num2} = {soma}");
        System.Console.WriteLine($"{num1} - {num2} = {subtracao}");
        System.Console.WriteLine($"{num1} * {num2} = {multiplicacao}");
        System.Console.WriteLine($"{num1} / {num2} = {divisao}");
    }
}