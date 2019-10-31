using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula125.Entitites;

namespace Aula125
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.00);
            Account acc2 = new SavingAccount(1002, "Anna", 500.00, 0.01);

            acc1.withdraw(10.00);
            acc2.withdraw(10.00);
         
            Console.WriteLine(acc1.balance);
            Console.WriteLine(acc2.balance);

            
            Console.ReadKey();
        }
    }
}
