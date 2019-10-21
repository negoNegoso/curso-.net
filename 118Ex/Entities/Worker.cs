using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _118Ex.Entities.Enums;

namespace _118Ex.Entities
{
    class Worker
    {
        public String name { get; set; }
        public WorkerLevel level { get; set; }

        public double baseSalary { get; set; }
        public Department department { get; set; }


        public List<HourContract> listContracts { get; private set; } = new List<HourContract>();
        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            this.name = name;
            this.level = level;
            this.baseSalary = baseSalary;
            this.department = department;
        }

        public void addContract(HourContract contract)
        {
            listContracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            listContracts.Remove(contract);
        }

        public double income(int year, int month)
        {
            double incomeValue = baseSalary;
            foreach (HourContract item in listContracts)
            {
                if (item.date.Year ==year && item.date.Month==month)
                {
                    incomeValue += item.totalValue();
                }

            }

            return incomeValue;

        }
    }
}
