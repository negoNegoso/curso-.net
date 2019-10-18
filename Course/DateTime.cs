using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class DateTime {
        public void pegarDados() {
            DateTime d11 = DateTime.Now;
            DateTime d12 = new DateTime(2018, 11, 25);
            DateTime d22 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d33 = new DateTime(2018, 11, 25, 20, 45, 3);

            DateTime d44 = DateTime.Now;
            DateTime d55 = DateTime.Today;
            DateTime d66 = DateTime.UtcNow;

            DateTime d111 = DateTime.Parse("2000-08-15");
            DateTime d222 = DateTime.Parse("20-08-15 13:05:58");
            DateTime d3 = DateTime.Parse("15/08/2000");
            DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");

            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);




            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d4);
            Console.WriteLine(d1.Ticks);


            Console.ReadKey();

        }
    }
}
