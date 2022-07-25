using System;
using System.Collections.Generic;
using System.Text;
using Primeiro.Entities;
using Primeiro.Helpers;
using Primeiro.Capitulo15.ExemploHashSetSortedSet.Entities;
using Primeiro.Capitulo15.ExemploHashSetSortedSet.Struct;

namespace Primeiro.LoaderController
{
    internal class ExemploHashSetSortedSetController : LoadController
    {
        public override void Rodar()
        {
            Console.WriteLine("Exemplo de HashSet e SortedSet");
            char escolha = char.Parse(FunctionsHelper.getFromConsole("Deseja rodar o exemplo de hashset? (s/n): ").ToLower());
            if (escolha == 's')
            {

                HashSet<string> set = new HashSet<string>();
                set.Add("TV");
                set.Add("Notebook");
                set.Add("Tablet");

                Console.WriteLine(set.Contains("Notebook"));
                foreach (String p in set)
                {
                    Console.WriteLine(p);
                }
            }

            escolha = char.Parse(FunctionsHelper.getFromConsole("Deseja rodar o exemplo de sortedset? (s/n): ").ToLower());
            if (escolha == 's')
            {
                SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
                SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
                //union
                SortedSet<int> c = new SortedSet<int>(a); // construtor já inserindo os elementos de a em c
                c.UnionWith(b);
                Console.Write("Union: ");
                printCollection(c);
                //intersection
                SortedSet<int> d = new SortedSet<int>(a); // construtor já inserindo os elementos de a em c
                d.IntersectWith(b);
                Console.Write("Intersectio: ");
                printCollection(d);
                //difference
                SortedSet<int> e = new SortedSet<int>(a); // construtor já inserindo os elementos de a em c
                e.ExceptWith(b);
                Console.Write("difference: ");
                printCollection(e);
            }

            escolha = char.Parse(FunctionsHelper.getFromConsole("Deseja rodar o exemplo de comparacao entre variaveis tipo valor e referencia? (s/n): ").ToLower());
            if (escolha == 's')
            {
                HashSet<Product> a = new HashSet<Product>();
                a.Add(new Product("TV", 900.0));
                a.Add(new Product("Notebook", 1200.0));

                HashSet<Point> b = new HashSet<Point>();
                b.Add(new Point(3, 4));
                b.Add(new Point(5, 10));

                Product prod = new Product("Notebook", 1200.0);

                Console.WriteLine(a.Contains(prod)); // em caso de variaveis tipo referencia, se nao implementar o método gethashcode e equals a busca será por referência....

                Point point = new Point(5, 10);
                Console.WriteLine(b.Contains(point)); // Variavel de tipo valor, a busca sera efetuada por valores, mesmo não tendo gethashcode e equals
            }          
        }
        static void printCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

    }
}
