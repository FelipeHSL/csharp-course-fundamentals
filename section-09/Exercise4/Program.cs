using System;   
using System.Globalization;
using Exercise4.Entities;

namespace Exercise4;

public class Program
{
	public static void Main()
	{
		List<TaxPayer> list = new List<TaxPayer>();
		Console.WriteLine("Enter the number of tax Payers: ");
		int n = int.Parse(Console.ReadLine());
		for (int i = 1; i <= n; i++)
		{
			Console.WriteLine($"TaxPayer #{i} data:");
			Console.Write("Individual or company (i/c): ");
			char ch = char.Parse(Console.ReadLine());
			Console.Write("Name: ");
			string name = Console.ReadLine();
			Console.Write("Annual Income: ");
			double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			if (ch == 'i')
			{
				Console.Write("Health expendituires: ");
				double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				list.Add(new Individual(name, anualIncome, healthExpenditure));
			}
			else
			{
				Console.Write("Number of employees: ");
				int num = int.Parse(Console.ReadLine());
				list.Add(new Company(name, anualIncome, num));
				
			}
		}

		double totalTaxes = 0.0;

		Console.WriteLine();
		Console.WriteLine("TAXES PAYERS:");
		foreach (TaxPayer taxpayer in list)
		{
			Console.WriteLine($"{taxpayer.Name}: $ {taxpayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
			
			totalTaxes += taxpayer.Tax();
			
		}
		Console.WriteLine();
		Console.WriteLine($"TOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
	}
}
