using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class switch_case {
        public void pegarValores() {
            int x = int.Parse(Console.ReadLine());
            switch (x) {

                case 1:
                    Console.WriteLine("Segundaaa");
                    break;
                case 2:
                    Console.WriteLine("terça");
                    break;
                case 3:
                    Console.WriteLine("quarta");
                    break;
                case 4:
                    Console.WriteLine("quinta");
                    break;
                case 5:
                    Console.WriteLine("sexta");
                    break;
                case 6:
                    Console.WriteLine("sab");
                    break;
                case 7:
                    Console.WriteLine("domingo");
                    break;
                default:
                    Console.WriteLine("Digite um número de 1 um a 7");
                    break;
            }
            Console.ReadKey();
        }
    }
}
