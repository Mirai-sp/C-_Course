using System;
using System.Collections.Generic;
using System.Linq;
using Primeiro.Entities;
using Primeiro.Capitulo17.ExemploFunc.Entities;

namespace Primeiro.LoaderController
{
    internal class ExemploFuncController : LoadController
    {
        public override void Rodar()
        {
            Console.WriteLine("Exemplo de Delegate Func: Representa um método que recebe zero ou mais argumentos, e retorna um valor ");
            Console.WriteLine();

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*               
                // Exemplo metodo como referencia
                List<string> result = list.Select(NameUpper).ToList();

                // Exemplo variavel para referenciar metodo

                Func<Product, string> func = NameUpper;
                List<string> result = list.Select(func).ToList();                

                // Exemplo variavel para lambda expression

                Func<Product, string> func = p => p.Name.ToUpper();
                List<string> result = list.Select(func).ToList();
            */


            // Exemplo com expressão Lambda
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
