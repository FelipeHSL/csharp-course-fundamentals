using System;
using System.Globalization;

namespace ExVect1
{
	class Exercise1
	{
		public static void Main(string[] args)
		{
			Estudante[] vect = new Estudante[10];
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine();
				Console.WriteLine($"Aluguel #{i}: ");
				Console.Write("Name: ");
				string name = Console.ReadLine();
				Console.Write("E-mail: ");
				string email = Console.ReadLine();
				Console.Write("Quarto: ");
				int quarto = int.Parse(Console.ReadLine());
				vect[quarto] =  new Estudante(name, email);
			}

			Console.WriteLine();
			Console.WriteLine("Quartos Alugados");
			for (int i = 0; i < 10; i++)
			{
				if(vect[i]!=null)
				{
					Console.WriteLine(i + ": " + vect[i]);
				}
			}
		}
	}
}