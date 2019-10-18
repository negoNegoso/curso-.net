
using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class Calculator3 {

        public static void Triple(int origin, out int result) {
            result = origin * 3;

        }

        public static void PegarMostrarvalores() {
            int a = 10;
            int triple;

            Calculator3.Triple(a, out triple);

            Console.WriteLine(triple);

            Console.ReadKey();
        }


    }
}
