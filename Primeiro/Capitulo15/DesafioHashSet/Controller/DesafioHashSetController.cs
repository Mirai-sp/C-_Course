using System;
using System.Collections.Generic;
using System.Text;
using Primeiro.Entities;
using Primeiro.Capitulo15.DesafioHashSet.Entities;
using Primeiro.Helpers;

namespace Primeiro.LoaderController
{
    class DesafioHashSetController : LoadController
    {
        public override void Rodar()
        {
            Console.WriteLine("Desafio de Hashset");
            char escolha = char.Parse(FunctionsHelper.getFromConsole("Deseja rodar o desafio do log de usuarios (hashSet)? (s/n): ").ToLower());
            if (escolha == 's')
            {
                HashSet<User> users = new HashSet<User>();
                users.Add(new User("amanda", DateTime.Parse("2020-08-26T20:45:08")));
                users.Add(new User("alex86", DateTime.Parse("2020-08-26T21:49:37")));
                users.Add(new User("bobbrown", DateTime.Parse("2020-08-27T03:19:13")));
                users.Add(new User("amanda", DateTime.Parse("2020-08-27T08:11:00")));
                users.Add(new User("jeniffer3", DateTime.Parse("2020-08-27T09:19:24")));
                users.Add(new User("alex86", DateTime.Parse("2020-08-27T22:39:52")));
                users.Add(new User("amanda", DateTime.Parse("2020-08-28T07:42:19")));
                // Devido o getHashcode e o equals ter sido implementado somente no atributo nome, repetições não serão incluídas na coleção, por isso não precisou fazer operações adicionais como intercecção....

                Console.WriteLine("Total Users: " + users.Count);
            }

            escolha = char.Parse(FunctionsHelper.getFromConsole("Deseja rodar o desafio da quantidade de alunos (hashSet)? (s/n): ").ToLower());
            if (escolha == 's')
            {
                int qtdCursos = int.Parse(FunctionsHelper.getFromConsole("Informe a quantidade de cursos: "));
                HashSet<int> alunos = new HashSet<int>();

                int qtdEstudante = 0;

                for (int i = 1; i<= qtdCursos; i++)
                {
                    qtdEstudante = int.Parse(FunctionsHelper.getFromConsole($"Informe a quantidade de alunos do curso #{i}: "));
                    for (int j = 1; j <= qtdEstudante; j++)
                    {
                        alunos.Add(int.Parse(Console.ReadLine()));
                    }
                }

                Console.WriteLine($"Total Students: {alunos.Count}");
            }
        }
    }
}
