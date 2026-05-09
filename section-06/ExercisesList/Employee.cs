using System;
using System.Globalization;

namespace ExercisesList;

public class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; private set; }
    
    public Employee(int id,string name, double salary)
    {
        
        Id = id;
        Name = name;
        Salary = salary;
    }
   
    public void IncreaseSalary(double percentage) {
        // Exemplo: 3000 += 3000 * 10.0 / 100.0 -> 3300.00
        Salary += Salary * percentage / 100.0;
    }


    

    override public string ToString()
    {
        return $"{Id} - {Name} - {Salary.ToString("F2",CultureInfo.InvariantCulture)}";
    }
    
}