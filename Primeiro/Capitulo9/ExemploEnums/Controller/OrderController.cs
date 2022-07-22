using System;
using Primeiro.Capitulo9.ExemploEnums.Entities;
using Primeiro.Capitulo9.ExemploEnums.Enums;
using Primeiro.Entities;

namespace Primeiro.LoaderController
{
    class OrderController : LoadController
    {
        public override void Rodar()
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
