using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int a, b;
        char op;
        Console.Clear();
        Console.WriteLine("#Calculadora @jvitorafb");
        Console.WriteLine();
        Console.WriteLine("Digite o primeiro número:");
        while (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Entrada inválida! Digite um número inteiro:");
        }

        Console.WriteLine("Digite o segundo número:");
        while (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Entrada inválida! Digite um número inteiro:");
        }

        Console.WriteLine("Escolha um operador:");
        Console.WriteLine(" - Subtração (-) | Adição (+) | Multiplicação (*) | Divisão (/)");
        op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.WriteLine("Calculando...");
        Thread.Sleep(1000);
        switch (op)
        {
            case '+':
                Console.WriteLine($"Resultado: {a} + {b} = {a + b}");
                break;
            case '-':
                Console.WriteLine($"Resultado: {a} - {b} = {a - b}");
                break;
            case '*':
                Console.WriteLine($"Resultado: {a} * {b} = {a * b}");
                break;
            case '/':
                if (b != 0)
                {
                    Console.WriteLine($"Resultado: {a} / {b} = {(double)a / b}");
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida!");
                }
                break;
            default:
                Console.WriteLine("Operador inválido! Escolha entre +, -, * ou /.");
                break;
        }
    }
}
