using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula211
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //definindo a consulta-> 
            //where serve para filtrar a fonte de dados, com a condição inserida no predicado
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //Executar a consulta
            foreach (int x  in result)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
