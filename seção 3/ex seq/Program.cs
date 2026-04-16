using System;
using System.Globalization;



namespace exercicio1
{
    class exercicioseq1
    {
        static void Main(string[] args)
        {
            ///ex1
            //Console.WriteLine("Entre com o primeiro valor");
            //int a1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com o 2 valor");
            //int a2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Resultado");
            //Console.WriteLine(a1+a2);

            //ex2

            //double R, T, pi = 3.14159;
            //Console.WriteLine("Digite o valor raio");
            //R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //T = pi * R * R;

            //Console.WriteLine("Valor: π =  ");
            //Console.WriteLine("T= " + T.ToString("f4", CultureInfo.InvariantCulture));

            //ex3
            //Console.WriteLine("Valor 1");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Valor 2");
            //int n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Valor 3");
            //int n3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Valor 4");
            //int n4 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Diferenca");
            //Console.WriteLine(n1*n2 - n3*n4);


            //ex4
            //Console.WriteLine("Entre com o numero do funcionario");
            //int numerofuncionario = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com as Horas Trabalhadas");
            //int horastrab = int.Parse(Console.ReadLine());
            //Console.WriteLine("Salario hora");
            //double salarioh = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //double salario = salarioh * horastrab;

            //Console.WriteLine($"Numero: {numerofuncionario} ");
            //Console.WriteLine($"Salario: {salario.ToString("f2", CultureInfo.InvariantCulture)}");


            //ex5

            //int qnt1, qnt2, cod1,cod2;
            //double preco1, preco2, total;

            //string[] valores = Console.ReadLine().Split(' ');
            //cod1 = int.Parse(valores[0]);
            //qnt1 = int.Parse(valores[1]);
            //preco1 = double.Parse(valores[2],CultureInfo.InvariantCulture);

            //valores = Console.ReadLine().Split(' ');
            //cod2 = int.Parse(valores[0]);
            //qnt2 = int.Parse(valores[1]);
            //preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //total = preco1 * qnt1 + preco2 * qnt2;

            //Console.WriteLine($"valor a pagar R$: {total.ToString("f2", CultureInfo.InvariantCulture)}");
            //
            //

            //ex6

            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;
            string[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0],CultureInfo.InvariantCulture);
            b = double.Parse(valores[1],CultureInfo.InvariantCulture);
            c = double.Parse(valores[2],CultureInfo.InvariantCulture);

            triangulo = a * c / 2.0;
            circulo = 3.14159 * c * c;
            trapezio = (a + b) / 2.0 * c;
            quadrado = b * b;
            retangulo = a * b;

            Console.WriteLine($"Triangulo: {triangulo.ToString("f3",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Circulo: {circulo.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapezio: {trapezio.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {quadrado.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retangulo: {retangulo.ToString("f3", CultureInfo.InvariantCulture)}");
        }

    }
}