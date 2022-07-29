using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string[] stringArray = Console.ReadLine().Split(' ');

        var listaNumeros = stringArray.Select(s => Convert.ToDouble(s));
        var listaNumeros1 = listaNumeros.OrderByDescending(s => s).ToList();

        listaNumeros1 = listaNumeros1.Where(s => s < 10).ToList();

        var A = listaNumeros1[0];
        var B = listaNumeros1[1];
        var C = listaNumeros1[2];

        double soma = Math.Pow(B, 2) + Math.Pow(C, 2);

        if (A >= (B + C))
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
            return;
        }
        if (Math.Pow(A, 2) == soma)
        {
            Console.WriteLine("TRIANGULO RETANGULO");
        }
        if (Math.Pow(A, 2) > soma)
        {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }
        if (Math.Pow(A, 2) < soma)
        {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }
        if (A == B && A == C)
        {
            Console.WriteLine("TRIANGULO EQUILATERO");
        }
        else if (A == B || B == C || C == A)
        {
            Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }
}
