using System;
using System.Globalization;
using System.Numerics;


namespace consoleapp12
{
    class program11
    {
        static void Main(string[] args)
        {
            ////ex1
            //Console.WriteLine("Entre com o Numero:");
            //int N1 = int.Parse(Console.ReadLine());

            //if (N1 >= 0)
            //{
            //    Console.WriteLine("Não Negativo!");
            //}
            //else{
            //    Console.WriteLine("Negativo");

            //}


            //ex2
            //Console.WriteLine("Digite o numero:");
            //int n2 = int.Parse(Console.ReadLine());
            //if (n2 % 2 == 0)
            //{
            //    Console.WriteLine("Par!");
            //}
            //else { Console.WriteLine("Impar!");}


            ///ex 3
            //Console.WriteLine("Entre com os valores Hora inicial e Hora final Separadas APENAS POR ESPACO");
            //string[] vet = Console.ReadLine().Split(' ');
            //int horainicial = int.Parse(vet[0]);
            //int horafinal = int.Parse(vet[1]);
            //int duracao;
            //if (horainicial < horafinal)
            //{
            //    duracao = horainicial - horafinal;
            //}
            //else
            //{
            //    duracao = 24 - horainicial + horafinal;


            //}
            //Console.WriteLine($"O Jogo Durou {duracao} Horas ");

            //ex 4

            //Console.WriteLine("Entre com os valores usando espaco");
            //string[] vet = Console.ReadLine().Split(' ');
            //int codigo = int.Parse(vet[0]);
            //int quantidade = int.Parse(vet[1]);

            //double total;
            //if (codigo == 1)
            //{
            //    total = quantidade * 4.0;
            //}
            //else if (codigo == 2)
            //{
            //    total = quantidade * 4.5;
            //}
            //else if (codigo == 3)
            //{
            //    total = quantidade * 5.0;
            //}
            //else if (codigo == 4)
            //{
            //    total = quantidade * 2.0;
            //}
            //else
            //{
            //    total = quantidade * 1.0;
            //}

            //Console.WriteLine($"Total em R$: {total.ToString("f2", CultureInfo.InvariantCulture)}");

            //ex5

            //Console.WriteLine("Entre com os valores Inteiros");
            //string[] vet = Console.ReadLine().Split(' ');
            //int A = int.Parse(vet[0]);
            //int B = int.Parse(vet[1]);
            //if (A % B == 0 || B % A == 0) {
            //    Console.WriteLine("Sao Multiplos");
            //}
            //else
            //{
            //    Console.WriteLine("Nao Sao Multiplos");
            //}


            //ex 6
            //Console.WriteLine("Digite valor");
            //double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //if (valor < 0 || valor > 100)
            //{
            //    Console.WriteLine("Fora de intervalo");
            //} else if (valor < 25)
            //{
            //    Console.WriteLine("Intervalo [0, 25]");
            //}else if (valor < 50)
            //{
            //    Console.WriteLine("Intervalo [25, 50]");
            //}else if(valor < 75)
            //{
            //    Console.WriteLine("Intervalo [50, 75]");

            //}
            //else
            //{
            //    Console.WriteLine("Intervalo [75, 100]");
            //}

            //ex 7
            //Console.WriteLine("Entre com valor: ");
            //string[] vet = Console.ReadLine().Split(' ');
            //double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            //double y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            //if (x == 0.0 && y == 0.0)
            //{
            //    Console.WriteLine("Origem");
            //}
            //else if (x > 0.0 && y > 0.0)
            //{
            //    Console.WriteLine("Q1");

            //}
            //else if (x < 0.0 && y > 0.0)
            //{
            //    Console.WriteLine("Q2");
            //}
            //else if(y < 0.0 && x < 0.0)
            //{
            //    Console.WriteLine("Q3");
            //}
            //else {Console.WriteLine("Q4"); }

            //ex8 
            Console.WriteLine("Entre com o Salario");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if (salario <= 2000)
            {
                imposto = 0.0;


            } else if (salario <= 3000)
            {
                imposto = (salario - 2000) * 0.08;
            } else if (salario <= 4500)
            {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
            }
            else
            {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }
            if (imposto == 0.0)
            {
                Console.WriteLine("Insento");
            }
            else
            {
                Console.WriteLine($"Valor a pagar {imposto.ToString("f2",CultureInfo.InvariantCulture)}");
            }

        }



    }
}