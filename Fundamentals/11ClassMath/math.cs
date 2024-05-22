using System;

class Program
{
    static void Main()
    {
        // Valor Absoluto
        int valorNegativo = -10;
        int valorAbsoluto = Math.Abs(valorNegativo);
        Console.WriteLine(string.Format("Abs({0}) = {1}", valorNegativo, valorAbsoluto));

        // Potência
        double baseNumero = 2;
        double expoente = 3;
        double potencia = Math.Pow(baseNumero, expoente);
        Console.WriteLine(string.Format("{0}^{1} = {2}", baseNumero, expoente, potencia));

        // Raiz Quadrada
        double numero = 16;
        double raizQuadrada = Math.Sqrt(numero);
        Console.WriteLine(string.Format("Sqrt({0}) = {1}", numero, raizQuadrada));

        // Seno e Cosseno (em radianos)
        double angulo = Math.PI / 4; // 45 graus em radianos
        double seno = Math.Sin(angulo);
        double cosseno = Math.Cos(angulo);
        Console.WriteLine(string.Format("Sin({0}) = {1}", angulo, seno));
        Console.WriteLine(string.Format("Cos({0}) = {1}", angulo, cosseno));

        // Arredondamentos
        double valorArredondar = 5.65;
        double valorArredondado = Math.Round(valorArredondar);
        Console.WriteLine(string.Format("Round({0}) = {1}", valorArredondar, valorArredondado));

        double valorArredondarParaCima = 5.3;
        double valorArredondadoParaCima = Math.Ceiling(valorArredondarParaCima);
        Console.WriteLine(string.Format("Ceiling({0}) = {1}", valorArredondarParaCima, valorArredondadoParaCima));

        double valorArredondarParaBaixo = 5.7;
        double valorArredondadoParaBaixo = Math.Floor(valorArredondarParaBaixo);
        Console.WriteLine(string.Format("Floor({0}) = {1}", valorArredondarParaBaixo, valorArredondadoParaBaixo));

        // Máximo e Mínimo
        int a = 10;
        int b = 20;
        int maximo = Math.Max(a, b);
        int minimo = Math.Min(a, b);
        Console.WriteLine(string.Format("Max({0}, {1}) = {2}", a, b, maximo));
        Console.WriteLine(string.Format("Min({0}, {1}) = {2}", a, b, minimo));

        // Constantes Math.PI e Math.E
        double pi = Math.PI;
        double e = Math.E;
        Console.WriteLine(string.Format("PI = {0}", pi));
        Console.WriteLine(string.Format("E = {0}", e));
    }
}
