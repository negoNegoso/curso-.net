using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula125.Entitites
{
    class BusinessAcount : Account
    {
        public double loanLimit { get; set; }

        public BusinessAcount()
        {
        }

        public BusinessAcount(int number, string stringHolder, double balance, double loanLimit) : base(number, stringHolder, balance)
        {
            this.loanLimit = loanLimit;
        }

        public void loan(double amount)
        {
            if (amount <= loanLimit)
                balance += amount;
        }
    }
}
