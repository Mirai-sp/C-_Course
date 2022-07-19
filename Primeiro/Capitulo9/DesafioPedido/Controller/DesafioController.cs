using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Primeiro.Helpers;
using Primeiro.Capitulo9.DesafioPedido.Entities;
using Primeiro.Capitulo9.DesafioPedido.Enums;

namespace Primeiro.Capitulo9.DesafioPedido.Controller
{
    class DesafioController
    {
        public static void Rodar()
        {
            
            Console.WriteLine("Entre com os dados do cliente");
            string nameClient = FunctionsHelper.getFromConsole("Name: ");
            string emailClient = FunctionsHelper.getFromConsole("Email: ");
            DateTime birthDateClient = DateTime.ParseExact(FunctionsHelper.getFromConsole("Birth Date ( DD/MM/YYYY ): "), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            int qtdItens = int.Parse(FunctionsHelper.getFromConsole("Quantos itens terão no pedido?: "));

            Client client = new Client(nameClient, emailClient, birthDateClient);
            Order order = new Order(DateTime.Now, client, OrderStatus.Processing);

            for (int i = 1; i<= qtdItens; i++)
            {
                Console.WriteLine("Informe o dado do ítem N#" + i);
                string productName = FunctionsHelper.getFromConsole("Descrição: ");
                int productQuantity = int.Parse(FunctionsHelper.getFromConsole("Quantidade: "));
                double productPrice = double.Parse(FunctionsHelper.getFromConsole("Preço: "), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(product, productQuantity, productPrice);

                order.AddItem(orderItem);
            }

            Console.WriteLine("Resumo do pedido");
            Console.WriteLine(order);
        }
    }
}
