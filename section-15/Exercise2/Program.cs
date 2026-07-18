using System;
using System.Linq;
using System.Globalization;
using System.IO;
using Exercise2.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file Path: ");
            string path = Console.ReadLine();
            Console.Write("Enter Salary");
            double limit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream)
                {
                    string[] lines = sr.ReadLine().Split(',');
                    string name = lines[0];
                    string email = lines[1];
                    double salary = double.Parse(lines[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));

                }

                var emails = list.Where(p => p.Salary > limit).OrderBy(p => p.Email).Select(p => p.Email);

                var sum = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);

                Console.WriteLine($"Email of people whose salary is more than {limit.ToString("f2",CultureInfo.InvariantCulture)}:  ");
                foreach (string email in emails) {
                    Console.WriteLine(email);
                }

                Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2",CultureInfo.InvariantCulture)}");
             }



        }
    }
}