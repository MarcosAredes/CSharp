using System;

    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;
            
            int soma = a + b;
            int subtracao = a - b;
            int multiplicacao = a * b;
            int divisao = a / b;
            int modulo = a % b;

            Console.WriteLine("Soma: " + soma);             // Saída: 13
            Console.WriteLine("Subtração: " + subtracao);   // Saída: 7
            Console.WriteLine("Multiplicação: " + multiplicacao); // Saída: 30
            Console.WriteLine("Divisão: " + divisao);       // Saída: 3
            Console.WriteLine("Módulo: " + modulo);         // Saída: 1

            a++; // Incremento
            b--; // Decremento

            Console.WriteLine("Incremento de a: " + a);     // Saída: 11
            Console.WriteLine("Decremento de b: " + b);     // Saída: 2
        }
    }

