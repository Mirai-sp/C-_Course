using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Primeiro.Entities;
using Primeiro.Capitulo17.ExercicioLinq.Entities;

namespace Primeiro.LoaderController
{
    class ExercicioLinqController : LoadController
    {
        public override void Rodar()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Tv", 900.00));
            products.Add(new Product("Mouse", 50.00));
            products.Add(new Product("Tablet", 350.50));
            products.Add(new Product("Hd case", 80.90));
            products.Add(new Product("Computer", 850.00));
            products.Add(new Product("Monitor", 290.00));

            var average = products.Select(p => p.Price).DefaultIfEmpty(0.00).Average();                                                  
            Console.WriteLine("Average Price: " + average.ToString("F2", CultureInfo.InvariantCulture));

            var productNameBellowAverage = (from p in products
                                            where p.Price <= average
                                            orderby p.Name descending
                                            select p.Name).ToList();

            productNameBellowAverage.ForEach(p => { Console.WriteLine(p); });
            Console.WriteLine();

            var productBellowAverage = (from p in products
                                        where p.Price <= average
                                        orderby p.Name
                                        orderby p.Price
                                        select p).ToList();
            
            productBellowAverage.ForEach(p => { Console.WriteLine(p); });

        }
    }
}
