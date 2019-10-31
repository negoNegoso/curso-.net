using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Aula185
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"c:\temp\file1.txt";
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message); ;
            }

            Console.ReadKey();

        }
    }
}
