using System;
using Pedido.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace Pedido.Entities
{
    class Order
    {
        DateTime Moment;
        OrderStatus Status;
        Client Client;
        List<OrderItem> Items = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
                foreach(OrderItem item in Items)
            {
                sum += item.SubTotal(item.Quantity,item.Price);

            }

            return sum;
        }
    }
}
