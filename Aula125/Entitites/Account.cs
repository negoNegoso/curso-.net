using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula125.Entitites
{
    class Account
    {
        public int number { get; private set; }
        public string holder { get; private set; }
        public double balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string Holder, double balance)
        {
            this.number = number;
            this.holder = holder;
            this.balance = balance;
        }

        public virtual void withdraw(double amount)
        {
            balance -= amount + 5.0;
        }

        public void deposit(double amount)
        {
            balance += amount;
        }
    }
}
