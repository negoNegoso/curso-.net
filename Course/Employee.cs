using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage) {
            this.Salary = Salary * (1.0 + (percentage / 100));
        }

        public override string ToString() {
            return "\n" + Id + ", " + Name + ", " + Salary; ;
        }

        public void pegarDados() {
            List<Employee> list = new List<Employee>();


            Console.Write("How many employees will be registered?");
            int qtdEmpregados = int.Parse(Console.ReadLine());



            for (int i = 0; i < qtdEmpregados; i++) {
                Console.WriteLine("Employee #" + (1 + i));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                Console.WriteLine();

                list.Add(new Employee(id, name, salary));

            }

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int idEscolhido = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine());

            Console.WriteLine();
            foreach (Employee item in list) {
                if (item.Id == idEscolhido) {
                    item.increaseSalary(percentage);
                } else {
                    Console.WriteLine("This id does not exist");
                }

            }

            Console.WriteLine("Update list of employees:");
            foreach (Employee item in list) {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
