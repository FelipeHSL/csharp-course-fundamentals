using System;
using System.Globalization;


namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            bank account;
            Console.WriteLine("Enter your account number.");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Log in as account holder.");
            string holder = Console.ReadLine();
            Console.WriteLine("Will there be an initial deposit (y/n)?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 'y' || resp == 'Y')
            {
                Console.WriteLine("Enter the initial deposit amount:");
                double depositAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new bank(number, holder, depositAmount);

            }
            else
            {
                account = new bank(number, holder);
            }

            Console.WriteLine();
            Console.WriteLine("Account details:");
            Console.WriteLine(account);
            Console.WriteLine();
            Console.WriteLine("Enter a deposit amount:");
            double amount = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            account.Deposit(amount);
            Console.WriteLine("Updated account details:");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.WriteLine("Enter an amount to withdraw: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(amount);
            Console.WriteLine("Updated account details:");
            Console.WriteLine(account);
            

        }
    }
}