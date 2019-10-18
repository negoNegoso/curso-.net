
using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class Calculator2 {

        public static void Triple(ref int x) {
            x = x * 3;

        }

        public static void PegarMostrarvalores() {
            int a = 10;
            Calculator2.Triple(ref a);

            Console.WriteLine(a);

            Console.ReadKey();
        }


    }
}
