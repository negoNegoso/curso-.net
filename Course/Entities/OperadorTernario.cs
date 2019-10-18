using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class OperadorTernario {
        public void pegarDados() {
            double preco = double.Parse(Console.ReadLine());
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);
            Console.ReadKey();
        }
    }
}
