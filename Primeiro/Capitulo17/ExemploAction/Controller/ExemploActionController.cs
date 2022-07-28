using System;
using System.Collections.Generic;
using System.Text;
using Primeiro.Entities;
using Primeiro.Capitulo17.ExemploAction.Entities;

namespace Primeiro.LoaderController
{
    class ExemploActionController : LoadController
    {
        public override void Rodar()
        {
            Console.WriteLine("Exemplo de Action: Representa um método void que recebe zero ou mais argumentos");
            // No exemplo sera acrescentado 10% no valor dos produtos
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.ForEach(UpdatePrice); // Exemplo passando funcao por referencia

            /* 
                // Exemplo variavel para metodo referencia                 
                Action<Product> act = UpdatePrice;
                list.ForEach(act);
            */

            /* 
                // Exemplo variavel para funcao lambda
                Action<Product> act = p => { p.Price += p.Price * 0.1; };
                list.ForEach(act);
            */

            // exemplo usando expressão lambda
            list.ForEach(p => { p.Price += p.Price * 0.1; }); // em funcoes lambda que nao possuam retorno ou seja, void usa-se chaves pois no caso a expressao sera executada como comando, como nao tem return neste caso funciona como void
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
