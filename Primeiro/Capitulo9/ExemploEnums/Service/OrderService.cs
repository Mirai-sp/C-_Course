using System;
using Primeiro.Capitulo9.ExemploEnums.Entities;
using Primeiro.Capitulo9.ExemploEnums.Enums;

namespace Primeiro.Capitulo9.ExemploEnums.Service
{
    class OrderService
    {
        public static void Rodar()
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // converter enum para string
            String txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            // Converter string para enumerado
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
