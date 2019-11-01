using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Aula190.Entitiess;
using Aula190.Services;

namespace Aula190
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car Model:");
            string model = Console.ReadLine();

            Console.WriteLine("Pickup (dd//MM/yyyy) hh:mm");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Return (dd//MM/yyyy) hh:mm");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter price per day: ");
            double day = double.Parse(Console.ReadLine());


            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rental = new RentalService(hour, day,new BrazilTaxService());

            rental.processInvoce(carRental);

            Console.WriteLine("INVOCE:");
            Console.WriteLine(carRental.invoice);




            Console.ReadKey();


        }
    }
}
