using System;

class Program
{
    static void Main()
    {
        // Declaração de variáveis booleanas
        bool value = true;
        bool value2 = false;

        // Operadores relacionais
        // Igualdade (==)
        int a = 5;
        int b = 5;
        bool isEqual = (a == b); // true

        // Diferença (!=)
        int c = 3;
        bool isNotEqual = (a != c); // true

        // Menor que (<)
        bool isLessThan = (c < b); // true

        // Maior que (>)
        int d = 7;
        bool isGreaterThan = (d > b); // true

        // Menor ou igual que (<=)
        bool isLessOrEqual = (a <= b); // true

        // Maior ou igual que (>=)
        bool isGreaterOrEqual = (d >= c); // true

        // Imprimindo resultados
        Console.WriteLine("isEqual: " + isEqual); // true
        Console.WriteLine("isNotEqual: " + isNotEqual); // true
        Console.WriteLine("isLessThan: " + isLessThan); // true
        Console.WriteLine("isGreaterThan: " + isGreaterThan); // true
        Console.WriteLine("isLessOrEqual: " + isLessOrEqual); // true
        Console.WriteLine("isGreaterOrEqual: " + isGreaterOrEqual); // true
    }
}
