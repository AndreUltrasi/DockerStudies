using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        //https://www.beecrowd.com.br/judge/pt/problems/view/1045
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string[] stringArray = Console.ReadLine()!.Split(' ');

        var listaNumeros = stringArray.Select(s => Convert.ToDouble(s));
        var listaNumerosOrdenados = listaNumeros.OrderByDescending(s => s).ToList();

        var A = listaNumerosOrdenados[0];
        var B = listaNumerosOrdenados[1];
        var C = listaNumerosOrdenados[2];

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
