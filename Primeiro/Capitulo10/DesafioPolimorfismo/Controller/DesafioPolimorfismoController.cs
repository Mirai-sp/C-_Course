using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Primeiro.Helpers;
using Primeiro.Capitulo10.DesafioPolimorfismo.Entities;
using Primeiro.Entities;

namespace Primeiro.Capitulo10.DesafioPolimorfismo.Controller
{
    class DesafioPolimorfismoController : LoadController
    {
        public override void Rodar()
        {
            int numProduct = int.Parse(FunctionsHelper.getFromConsole("Enter the number of the products: "));
            List<Product> products = new List<Product>();

            for (int i = 1; i <= numProduct; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                char kind = char.Parse(Helpers.FunctionsHelper.getFromConsole("Commom, used or imported (c/u/i): ").ToLower());
                string name = FunctionsHelper.getFromConsole("Name: ");
                double price = double.Parse(Helpers.FunctionsHelper.getFromConsole("Price: "), CultureInfo.InvariantCulture);

                if (kind == 'u')
                {
                    DateTime manufactureDate = DateTime.ParseExact(Helpers.FunctionsHelper.getFromConsole("Manufacture date (DD/MM/YYYY): "), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (kind == 'i')
                {
                    double customsfee = double.Parse(Helpers.FunctionsHelper.getFromConsole("Customs fee: "), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsfee));
                }
                else
                    products.Add(new Product(name, price));
            }

            Console.WriteLine("Price Tags:");
            foreach (Product prod in products)
                Console.WriteLine(prod.PriceTag());
        }
    }
}
