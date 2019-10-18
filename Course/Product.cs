using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class Product {
        public string Name { get; set; }
        public double Price { get; set; }

        public void pegarDados() {
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];

            for (int i = 0; i < vect.Length; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                vect[i] = new Product { Name = name, Price = price };

            }
            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i].Price;

            }
            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("##,###.00"));

            Console.ReadKey();
        }
    }
}
