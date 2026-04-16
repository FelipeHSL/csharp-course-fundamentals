using Exclass;
using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace exercicio11
{
    class exercicioclass1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Aqui Comeca o Exercicio 1");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da Pessoa 1");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Dados da Pessoa 2");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if(p1.idade > p2.idade)
            {
                Console.WriteLine("Possoa 1 e a mais velha Nome: " +p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa 2 e a mais velha Nome: "+ p2.Nome);
            }

            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Aqui Comeca o Exercicio 2");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do Primeiro Funcionario");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Dados do Segundo Funcionario");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("Media de salario de ambos os funcionarios é: "+ media.ToString("f2",CultureInfo.InvariantCulture));


        }   
    }   
}