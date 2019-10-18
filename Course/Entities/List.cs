using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class List {
        List<string> list = new List<string>();
        /*
        //list add na última posição
        list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            //list.Insert insere em um determinado index
            list.Insert(2, "Marco");

            //conta quantos elementos tem em sua lista
            Console.WriteLine("List Count:" + list.Count);

            
            foreach (string item in list) {
                Console.WriteLine(item);
            }

    // espera um predicado como parametro,com lambda uma função booleana
    //sem lambida
    // string s1 = list.Find(Test);
    // '=>' significa tal que
    string s1 = list.Find(x => x[0] == 'A');
    Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
    Console.WriteLine("Last 'A': " + s2);


            int pos1 = list.FindIndex(x => x[0] == 'A');
    Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
    Console.WriteLine("Last position 'A': " + pos2);


            List<string> list2 = list.FindAll(x => x.Length == 5);
    Console.WriteLine("-------------------");
            foreach (string item in list2) {
                Console.WriteLine(item);
            }



list.Remove("Alex");
            Console.WriteLine("-------------------");
            foreach (string item in list) {
                Console.WriteLine(item);
            }


            list.RemoveAt(3);
            Console.WriteLine("-------------------");
            foreach (string item in list) {
                Console.WriteLine(item);
            }
            //(posição,quantas posições serão removidas)
            list.RemoveRange(2,1);
            Console.WriteLine("-------------------");
            foreach (string item in list) {
                Console.WriteLine(item);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------------");
            foreach (string item in list) {
                Console.WriteLine(item);
            }




            Console.ReadKey();


        }

        static bool Test(string s) {
    return s[0] == 'A';
}*/
    }
}
