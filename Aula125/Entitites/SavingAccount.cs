using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula125.Entitites
{
    class SavingAccount : Account
    {
        public double interestRate { get; set; }

        public SavingAccount()
        {
        }

        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            this.interestRate = interestRate;
        }

        public void updateBalance()
        {
            balance += balance * interestRate;
        }

    }
}
