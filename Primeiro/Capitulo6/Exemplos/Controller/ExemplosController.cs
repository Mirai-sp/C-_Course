using System;
using System.Collections.Generic;
using System.Text;
using Primeiro.Entities;
using Primeiro.Capitulo6.Exemplos.Structs;
using Primeiro.Helpers;

namespace Primeiro.Capitulo6.Exemplos.Controller
{
    class ExemplosController : LoadController
    {
        public override void Rodar()
        {
            // ******************* STRUCTS **************************
            char ask = char.Parse(FunctionsHelper.getFromConsole("Deseja rodar o exemplo de struct (s/n): ").ToLower());
            if (ask == 's')
            {                
                Point p;
                //Console.WriteLine(p); // erro: variável não atribuída
                p.X = 10;
                p.Y = 20;
                Console.WriteLine(p);
                p = new Point();
                Console.WriteLine(p);
            }

            // ******************** NULLNABLES ***********************
            ask = char.Parse(FunctionsHelper.getFromConsole("Deseja rodar o exemplo de Nullnables (s/n): ").ToLower());
            if (ask == 's')
            {
                double? x = null; // por padrao variaveis structs o compilador nao aceita null, o double? quer dizer nullnable double ou seja permitirá null na variavel double
                double? y = 10.0;

                Console.WriteLine(x.GetValueOrDefault());
                Console.WriteLine(y.GetValueOrDefault());
                Console.WriteLine(x.HasValue);
                Console.WriteLine(y.HasValue);
                if (x.HasValue)
                    Console.WriteLine(x.Value);
                else
                    Console.WriteLine("X is null");
                if (y.HasValue)
                    Console.WriteLine(y.Value);
                else
                    Console.WriteLine("Y is null");

                // Null conditional null - mesmo funcionamento que o php
                double a = x ?? 5;
                double b = y ?? 5;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }

            // Exemplo usando params para deixar a chamada da funcao menos verbosa.
            ask = char.Parse(FunctionsHelper.getFromConsole("Deseja rodar o exemplo de ref / out (s/n): ").ToLower());
            if (ask == 's')
            {
                int Sum(params int[] numbers) // funcao declarada inline usando params
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sum += numbers[i];
                    }
                    return sum;
                }

                Console.WriteLine(Sum(2, 4, 6));
                Console.WriteLine(Sum(8, 3, 2));


                // Exemplo de parametros ref e out, ref exige que a variavel seja iniciada, já o out nao possui esta necessidade.
                void Triple(ref int x)
                {
                    x = x * 3;
                }

                int refVar = 3;
                Triple(ref refVar);
                Console.WriteLine("using ref triple: " + refVar);

                void TripleOut(int origin, out int result)
                {
                    result = origin * 3;
                }

                int outA = 10;
                int tripleOut;
                TripleOut(outA, out tripleOut);
                Console.WriteLine("using out triple: " + tripleOut);
            }

            // Exemplo de listas
            ask = char.Parse(FunctionsHelper.getFromConsole("Deseja rodar o exemplo de ref / out (s/n): ").ToLower());
            if (ask == 's')
            {
                List<string> list = new List<string>();
                list.Add("Maria");
                list.Add("Alex");
                list.Add("Bob");
                list.Add("Anna");
                list.Insert(2, "Marco");
                foreach (string obj in list)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine("List count: " + list.Count);
                string s1 = list.Find(x => x[0] == 'A'); // Predicate é uma labda function, poderia-se criar uma funcao e passar a mesma como parametro, mas é mais simples e usual passar uma funcao anonima(lambda function)
                Console.WriteLine("First 'A': " + s1);
                string s2 = list.FindLast(x => x[0] == 'A');
                Console.WriteLine("Last 'A': " + s2);
                int pos1 = list.FindIndex(x => x[0] == 'A');
                Console.WriteLine("First position 'A': " + pos1);
                int pos2 = list.FindLastIndex(x => x[0] == 'A');
                Console.WriteLine("Last position 'A': " + pos2);
                List<string> list2 = list.FindAll(x => x.Length == 5);
                Console.WriteLine("---------------------");
                foreach (string obj in list2)
                {
                    Console.WriteLine(obj);
                }
                list.Remove("Alex");
                Console.WriteLine("---------------------");
                foreach (string obj in list)
                {
                    Console.WriteLine(obj);
                }
                list.RemoveAll(x => x[0] == 'M');
                Console.WriteLine("---------------------");
                foreach (string obj in list)
                {
                    Console.WriteLine(obj);
                }
            }
        }
    }
}
