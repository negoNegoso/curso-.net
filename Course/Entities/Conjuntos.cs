using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class Conjuntos {

        public void pegarValores() {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();


            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            foreach (int item in A) {
                Console.WriteLine(item);
            }

            if (A.Contains(3)) {
                Console.WriteLine(3 + " pertence ao conjunto A");
            }

            Console.ReadKey();

        }
    }
}
