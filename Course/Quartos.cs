using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class Quartos {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public void PegarDados() {
            Quartos[] quartos = new Quartos[9];

            Console.Write("How many rooms will be rented? ");
            int nroQuartos = int.Parse(Console.ReadLine());

            while (nroQuartos > quartos.Length) {
                Console.Write("Digite uma quantidade de quartos até 10");
                nroQuartos = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < nroQuartos; i++) {

                Console.WriteLine("Rent #" + (i + 1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                quartos[room] = new Quartos { Name = name, Email = email, Room = room };
                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < quartos.Length; i++) {
                if (quartos[i] != null) {
                    Console.WriteLine(quartos[i].Room + ": " + quartos[i].Name + ", " + quartos[i].Email);
                }
            }

            Console.ReadKey();
        }
    }
}
