using System;
using Primeiro.Entities;
using Primeiro.Capitulo15.ExemploGenerics.Entities;


namespace Primeiro.LoaderController
{
    class ExemploGenericsController : LoadController
    {
    public override void Rodar()
    {
            Console.WriteLine("Exemplo de Generics");
            Console.WriteLine();
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
}
}
