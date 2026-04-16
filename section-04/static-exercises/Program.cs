using System;
using System.Globalization;

namespace ClasseEstaticaEx
{
    class ClassExtEx
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cotacao ");
            double cotacaoo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos Dolares voce vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacaoo);
            Console.WriteLine("Valor a ser pago em Reais = " + result.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}