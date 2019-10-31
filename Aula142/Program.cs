using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula142.Entities;

namespace Aula142
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Room number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if (checkout <= checkin)
            {
                Console.WriteLine("Erro de reserva a data de checkout é menor ou igual a data de checking");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine();

                Console.Write("Enter data to update the reservation: ");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                DateTime now = DateTime.Now;
                if (checkin<=checkOut)
                {
                    reservation.updateDate(checkin, checkout);

                }
            }

            Console.ReadKey();




        }
    }
}
