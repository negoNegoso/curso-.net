using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula122.Entities;
using Aula122.Entities.Enums;

namespace Aula122.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            String name = Console.ReadLine();

            Console.Write("Email: ");
            String email = Console.ReadLine();

            Console.WriteLine("Birth date (DD/MM/YYYY): "+DateTime.Now);
            DateTime date = DateTime.Now;
            Console.WriteLine("------------//------------");

            Console.WriteLine("Enter order data: ");

            Console.WriteLine("Choose one of the statuses:\n0 - PENDING_PAYMENT\n1-PROCESSING\n2 - SHIPPED\n3- DELIVERED: ");
            int statusCap = int.Parse(Console.ReadLine());
            while (statusCap < 0 || statusCap > 3)
            {
                Console.WriteLine("Choose one of the statuses:\n0 - PENDING_PAYMENT\n1-PROCESSING\n2 - SHIPPED\n3- DELIVERED: ");
                statusCap = int.Parse(Console.ReadLine());
            }

            OrderStatus status;

            switch (statusCap)
            {
                case 0:
                    status = OrderStatus.PENDING_PAYMENT;
                    break;
                case 1:
                    status = OrderStatus.PROCESSING;
                    break;
                case 2:
                    status = OrderStatus.SHIPPED;
                    break;
                case 3:
                    status = OrderStatus.DELIVERED;
                    break;
            }

            Console.Write("How many items to this order?");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("Enter #"+(i+1)+" item data: ");

                Console.Write("Product name:");
                String nameProduct = Console.ReadLine();

                Console.Write("Product price:");
                double priceProduct =double.Parse(Console.ReadLine());

                Console.Write("Product quantity:");
                int quantityProduct = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, priceProduct);

                order.addItem(new OrderItem(quantityProduct, priceProduct));
            }





        }
    }
}
