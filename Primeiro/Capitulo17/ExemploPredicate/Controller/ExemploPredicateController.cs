using System;
using System.Collections.Generic;
using System.Text;
using Primeiro.Entities;
using Primeiro.Capitulo17.ExemploPredicate.Entities;

namespace Primeiro.LoaderController
{
    class ExemploPredicateController : LoadController
    {
        public override void Rodar()
        {
            Console.WriteLine("Exemplo Predicate: Representa um método que recebe um objeto do tipo T e retorna um valor booleano");
            // No exemplo removera da lista todos os itens maiores que 100
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // passando funcao como parametro
            //list.RemoveAll(ProductTest);

            // exemplo usando funcao lambda
            list.RemoveAll(p => p.Price >= 100.0);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
