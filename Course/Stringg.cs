using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class Stringg {
        public void pegarDados() {
            string original = "abcde FGHIJ abc DEFG    ";
            string original2 = "abcde FGHIJ abc DEFG    ";
            string s1 = original.ToUpper();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);

            Console.WriteLine("Original :" + original);
            Console.WriteLine("ToUpper: " + s1);
            Console.WriteLine("ToLower: " + original.ToLower());
            Console.WriteLine("Sem espaços: " + original.Trim());

            Console.WriteLine("indexOf: " + n1);
            Console.WriteLine("Last indexOf: " + n2);
            Console.WriteLine("sub: " + s4);


            Console.ReadKey();
        }
    }
}
