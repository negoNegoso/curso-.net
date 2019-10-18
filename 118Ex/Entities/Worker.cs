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

        public Worker()
        {
            
        }
    }
}
