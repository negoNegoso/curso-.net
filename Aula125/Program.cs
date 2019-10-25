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
            BusinessAcount acount = new BusinessAcount(8010, "Bob Bronw", 100.00, 500.00);

            Console.WriteLine(acount.balance);

            Account account = new Account(1001, "Alex", 0.0);
            BusinessAcount businessAcount = new BusinessAcount(1002, "Maria", 0.0, 500.00);

            Account acc1 = businessAcount;
            Account acc2 = new BusinessAcount(1003, "Bob", 0.0, 200.00);
            Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01);

            
            Console.ReadKey();
        }
    }
}
