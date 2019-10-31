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

        /* utilizando somente o override
         public override void withdraw(double amount)
         {
             balance -=amount;
         }
        */

        //utilizando a palavra base
        public sealed override void withdraw(double amount)
        {
            base.withdraw(amount);
            balance -= 2.0;
        }



    }
}
