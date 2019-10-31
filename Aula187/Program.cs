using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aula187
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\myfolder";
            try
            {
                //1° *-> qualquer nome de arquivo e o 2° * qualquer tipo de extensão, o terceiro argumento é a opção de busca
                //All directorios todas as pastas
                //TopDirectoryOnly - só onde estou

                //Para lsitar subpastas
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                //para listar os arquivos
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //para criar uma pasta
               Directory.CreateDirectory(path + @"\newFolder");
                
            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message) ;
            }

            Console.ReadKey();
        }
    }
}
