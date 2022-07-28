using System;
using System.Collections.Generic;

using Primeiro.Entities;
using Primeiro.Capitulo17.ExemploComparison.Entities;

namespace Primeiro.LoaderController
{
    class ExemploComparisonController : LoadController
    {
        public override void Rodar()
        {
            Console.WriteLine("Exemplo Comparison");

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            // Abordagens possíveis

            // usando metodo como referencia
            //list.Sort(CompareProducts); 

            /* 
               // Referencia para variavel delegate
               Comparison<Product> comp = CompareProducts;
               list.Sort(comp);
            */

            /*
               // lambda Expression para variavel delegate
               Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
               list.Sort(comp);
             */


            // Inline Lambda Expression
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
