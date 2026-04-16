using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace forex11
{
    class forex12
    {
        static void Main(string[] args)
        {

            //ex1
            //int x = int.Parse(Console.ReadLine());

            //for (int i = 0; i < x; i++) {
            //    if (i % 2 != 0) { 
            //        Console.WriteLine(i);
            //    }
            // }


            //---------------------------------------------------------------------------------------------------------------------------------------

            //ex2
            //int n = int.Parse(Console.ReadLine());

            //int count_in = 0;
            //int count_out = 0;

            //for (int i = 0; i < n; i++) {
            //    int x = int.Parse(Console.ReadLine());
            //    if (x >= 10 && x <= 20)
            //    {

            //        count_in++;
            //    }
            //    else
            //    {
            //        count_out++;
            //    }

            //    Console.WriteLine(count_in + " IN ");
            //    Console.WriteLine(count_out + " OUT ");
            //}

            //---------------------------------------------------------------------------------------------------------------------------------------

            //ex3

            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    string[] valor = Console.ReadLine().Split(' ');
            //    double a = double.Parse(valor[0], CultureInfo.InvariantCulture);
            //    double b = double.Parse(valor[1], CultureInfo.InvariantCulture);
            //    double c = double.Parse(valor[2], CultureInfo.InvariantCulture);

            //    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10;
            //    Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));
            //}

            //---------------------------------------------------------------------------------------------------------------------------------------

            //ex 4
            //Console.WriteLine("Digite Quantas Divisoes deseja");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Pode Digitar agora");

            //for (int i = 0; i < n; i++) {
            //    string[] valor = Console.ReadLine().Split(' ');
            //    int a = int.Parse(valor[0], CultureInfo.InvariantCulture);
            //    int b = int.Parse(valor[1], CultureInfo.InvariantCulture);

            //    if (b == 0)
            //    {
            //        Console.WriteLine("divisao impossivel");
            //        Console.WriteLine("---------------------------------------");
            //    }
            //    else
            //    {
            //        double div = (double)a/b;
            //        Console.WriteLine(div.ToString("f2",CultureInfo.InvariantCulture));
            //        Console.WriteLine("---------------------------------------");
            //    }




            //}
            //---------------------------------------------------------------------------------------------------------------------------------------
            //ex5
            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
                
            }
            Console.WriteLine("valor fatorial: " + fat);
        }
    }
}