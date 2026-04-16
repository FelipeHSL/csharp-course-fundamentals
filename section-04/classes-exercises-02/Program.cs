using ClassesEX;
using System;
using System.Globalization;

namespace Exerciciosclasse
{
    class Exercicios3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercio 1");
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre com a altura e Largura do Retangulo");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area: " + ret.Area().ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro: " + ret.Perimetro().ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + ret.Diagonal().ToString("f2", CultureInfo.InvariantCulture));

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Exercicio 2");

            Funcionario fun = new Funcionario();
            Console.WriteLine("Dados Dos Funcionarios");
            Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Salario Bruto: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.Write("Imposto: ");
            fun.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + fun);
            Console.WriteLine("");
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            fun.AumentarSalario(porc);
            Console.WriteLine("");
            Console.WriteLine("Dados Atualizados: " + fun);

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Exercicio 3");
            Console.WriteLine();
            Aluno aluno = new Aluno();
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 Notas do aluno: " + nome);
            Console.WriteLine();
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final = " + aluno.NotaFinal().ToString("f2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado()) {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltam " +aluno.NotaRestante().ToString("f2",CultureInfo.InvariantCulture) + " Pontos");
            }
            
        }
    }
}