using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course {
    class Matriz {

        public void pegarValores() {
            double[,] mat = new double[2, 3];
            Console.WriteLine(mat.Length);

            Console.WriteLine(mat.Rank);

            //qtdLinhas
            Console.WriteLine(mat.GetLength(0));
            //qtdColunas
            Console.WriteLine(mat.GetLength(1));

            Console.ReadKey();

        }
        
    }
}
