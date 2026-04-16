using System;
using System.ComponentModel.Design;
using System.Net.Mail;

namespace program11
{
    class whileex11
    {
        static void Main(string[] args)
        {
            //ex1
            //Console.WriteLine("Escreva sua Senha: ");
            //int x = int.Parse(Console.ReadLine());
            //int senha = 2002;
            //while(x != senha)
            //{
            //    Console.WriteLine("Senha Invalida");
            //    Console.WriteLine("Digite a senha novamente");
            //    x = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Acesso Permitido");

            //ex2   
            //string[] valores = Console.ReadLine().Split(' ');
            //int x = int.Parse(valores[0]);
            //int y = int.Parse(valores[1]);

            //while (x != 0 && y != 0) {
            //    if (x > 0 && y > 0)
            //    {
            //        Console.WriteLine("Primeiro");
            //    }else if( x < 0 && y > 0)
            //    {
            //        Console.WriteLine("Segundo");
            //    }else if(x < 0 && y < 0)
            //    {
            //        Console.WriteLine("Terceiro");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Quarto");
            //    }

            //    valores = Console.ReadLine().Split(' ');
            //    x = int.Parse(valores[0]);
            //    y = int.Parse(valores[1]);


            //ex 3

            int al = 0;
            int ga = 0;
            int di = 0;
            Console.WriteLine("Digite o Numero Desejado de 1 A 4: ");
            int x = int.Parse(Console.ReadLine());
            while (x != 4)
            {
                if (x == 1)
                {
                    al++;
                }
                else if (x == 2) {
                    ga++;

                }
                else if( x == 3) {
                    di++;

                }
                Console.WriteLine("Digite novamente o codigo entre 1 e 4");
                x = int.Parse(Console.ReadLine());


            }
            Console.WriteLine("Muito obrigado");
            Console.WriteLine("Álcool: " + al);
            Console.WriteLine("Gasolina: " + ga);
            Console.WriteLine("Diesel: " + di);

        }

        
    }
}