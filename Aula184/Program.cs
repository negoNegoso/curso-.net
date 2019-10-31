using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aula184
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                ////segundo argumento da função é para definir como vc vai instacinar o seu obeto
                // fs = new FileStream(path, FileMode.Open);
                // sr = new StreamReader(fs);
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An erro occured");
                Console.WriteLine(e.Message);
            }

            finally
            {
                if (sr != null) sr.Close();
            }
            Console.ReadKey();
        }
    }
}
