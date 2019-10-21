using System;
using System.Globalization;
using _118Ex.Entities;
using _118Ex.Entities.Enums;

namespace _118Ex
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter department's name: ");
            String nameD = Console.ReadLine();
            Department department = new Department(nameD);

            Console.Write("Enter work data");
            Console.Write("Name: ");
            String name = Console.ReadLine();

            Console.Write("Level  (Junior/MidLevel/Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine().ToUpper());

            Console.WriteLine(level);

            Console.Write("Base Salary: ");
            double baseSalary = Double.Parse(Console.ReadLine());

            Console.Write("How many contracts to this worker?");
            int qtdContratos = int.Parse(Console.ReadLine());

            Worker worker = new Worker(name, level, baseSalary, department);


            for (int i = 0; i < qtdContratos; i++)
            {
                int nroContract = i;
                Console.Write("Enter #" + (nroContract + 1) + " contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Durations (hours): ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine();

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.addContract(contract);
            }

            Console.WriteLine("Enter month and year to calculate income(MM/YYYY):");
            DateTime dateGanho = DateTime.Parse(Console.ReadLine());
            int mesGanho = dateGanho.Month;
            int anoGanho = dateGanho.Year;

            Console.WriteLine("Name: " + worker.name);
            Console.WriteLine("Department: " + worker.department);
            Console.WriteLine("Income for " + mesGanho + "/" + anoGanho + ": " + worker.income(anoGanho, mesGanho));

            Console.ReadKey();





        }
    }
}
