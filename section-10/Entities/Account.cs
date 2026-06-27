using System.Globalization;

namespace Exercise1.Entities;
using System;
using Exercise1.Entities.Exceptions;

public class Account
{
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }
    public double WithdrawLimit { get; set; }

    public Account()
    {
        
    }

    public Account(int number, string holder, double balance, double withdrawLimit)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
        WithdrawLimit = withdrawLimit;
        
    }
    
    public void  Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (Balance < WithdrawLimit)
        {
            throw new DomainExceptions("Withdraw limit exceeded");
        }

        if (Balance < amount)
        {
            throw new DomainExceptions("Insufficient funds");
        }
        Balance -= amount;
    }


}