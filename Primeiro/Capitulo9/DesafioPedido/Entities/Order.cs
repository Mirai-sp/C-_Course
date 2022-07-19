using System;
using System.Globalization;
using System.Text;
using System.Collections.Generic;
using Primeiro.Capitulo9.DesafioPedido.Enums;

namespace Primeiro.Capitulo9.DesafioPedido.Entities
{
    class Order
    {
        public DateTime Momment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client{ get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }
        public Order(DateTime momment, Client client, OrderStatus status)
        {
            Momment = momment;
            Client = client;
            Status = status;
        }

        public void AddItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
                sum += item.SubTotal();

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Client: ").AppendLine(Client.Name).
            Append("Date Time: ").AppendLine(Momment.ToString("dd/MM/yyyy HH:mm:ss")).
            Append("Status: ").AppendLine(Status.ToString()).
            AppendLine("Itens:");
            if (Items.Count == 0)
                sb.AppendLine("No Itens Found.");
            else
                foreach (OrderItem item in Items)
                    sb.Append("   Name:").
                    AppendLine(item.Product.Name).
                    Append("    Quantity: ").AppendLine(item.Quantity.ToString()).
                    Append("    Price: ").AppendLine(item.Price.ToString("F2", CultureInfo.InvariantCulture)).
                    Append("    SubTotal: ").AppendLine(item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
                

            sb.Append("Total: ").AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
