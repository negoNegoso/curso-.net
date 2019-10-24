using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula122.Entities.Enums;
using Aula122.Entities;

namespace Aula122.Entities
{
    class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }
        List<OrderItem> listOrderItems = new List<OrderItem>();


        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status)
        {
            this.moment = moment;
            this.status = status;
        }

        public void addItem(OrderItem item)
        {
            listOrderItems.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            listOrderItems.Remove(item);
        }

        public double total()
        {
            double total = 0.0;
            foreach (OrderItem item in listOrderItems)
            {

                total += item.subTotal();
            }
            return total;
        }



    }
}
