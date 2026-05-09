using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ExercisesList
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("How many employees will be registered?");
			int n = int.Parse(Console.ReadLine());
			
			List<Employee> list = new List<Employee>();
			
				// ... lê dados e faz list.Add(new Employee(...))
			for (int i = 1; i <= n; i++)
			{
				Console.Write("Id: ");
				int id = int.Parse(Console.ReadLine());
				
				while (list.Any(x => x.Id == id)) {
					Console.Write("Id already taken! Try another id: ");
					id = int.Parse(Console.ReadLine());
				}
				
				Console.Write("Name: ");
				string name = Console.ReadLine();
				
				Console.Write("Salary: ");
				double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				list.Add(new Employee(id, name, salary));
				
				
				
			}
			
			Console.Write("Enter the employee id that will have salary increase: ");
			int idBusca = int.Parse(Console.ReadLine());

			Employee emp = list.Find(x => x.Id == idBusca);

			if (emp != null) {
				Console.Write("Enter the percentage: ");
				double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				emp.IncreaseSalary(porcentagem);
			} else {
				Console.WriteLine("This id does not exist!");
			}


			Console.WriteLine("Updated list of employees:");
			foreach (Employee obj in list) {
				Console.WriteLine(obj);
			}
			
			Console.WriteLine();
			Console.WriteLine("Updated list of employees:");
			foreach (Employee obj in list) {
				Console.WriteLine(obj.Id + ", " + obj.Name + ", " + obj.Salary.ToString("F2", CultureInfo.InvariantCulture));
			}


		}
	}
}