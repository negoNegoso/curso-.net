using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula190.Entitiess
{
    class Invoice
    {
        public double basicPayment { get; set; }
        public double tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            this.basicPayment = basicPayment;
            this.tax = tax;
        }
        public double totalPayment
        {
            get { return basicPayment + tax; }
        }

        public override string ToString()
        {
                        
             return "Basic Payment: " + basicPayment.ToString("##,###.00")
                + "\n Tax: " + tax
                +"\n Total Payments: "+totalPayment.ToString("##,###.00");
             
        }
    }
}
