using System;
using System.Globalization;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {

        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            //enum para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //string para enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

            Console.WriteLine(order);
            Console.ReadKey();
        }


    }

}


