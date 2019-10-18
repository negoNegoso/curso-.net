using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _118Ex.Entities
{
    class HourContract
    {
        public DateTime date { get; private set; }
        public Double valuePerHour { get; private set; }
        public int hours { get; private set; }

        public Double totalValue()
        {
            return valuePerHour * hours;
        }
    }
}
