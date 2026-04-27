using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex1
{
    class bank
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }


        public bank(int number, string holder)
        {
            Number = number;
            Holder = holder;
        }

        public bank(int number, string holder, double balance) : this(number, holder)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public override string ToString()
        {
            return "Account " +
                Number
                +", Holder "
                +Holder
                +", Balance: "
                +Balance.ToString("f2", CultureInfo.InvariantCulture);
        }
       
    }
}
