using System;
using System.Threading.Tasks;
using _118Ex.Entities;
using _118Ex.Entities.Enums;

namespace _118Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name");
            String nameD = Console.ReadLine();
            Department department = new Department(nameD);

            Console.WriteLine("Enter work data");
            Console.WriteLine("Name");
            String name = Console.ReadLine();

            Console.WriteLine("Level  (Junior/MidLevel/Senior");
            WorkerLevel level = WorkerLevel.JUNIOR;

            //OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
     
            //WorkerLevel levelh = Enum.Parse<WorkerLevel>(Console.ReadLine().ToUpper());



        }
    }
}
