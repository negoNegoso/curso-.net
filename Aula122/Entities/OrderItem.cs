using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula122.Entities
{
    class OrderItem
    {
        private int quantity { get; set; }
        private double price { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price)
        {
            this.quantity = quantity;
            this.price = price;
        }

        public double subTotal()
        {
            return quantity * price;
        }
    }
}
