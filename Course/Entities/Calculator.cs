
using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class Calculator {

        public static int Sum(params int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }

        public void PegarMostrarvalores() {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 3, 4);
            int s3 = Calculator.Sum(2, 3, 4, 5);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            Console.ReadKey();
        }


    }
}
