using System;
using System.Collections.Generic;
using Primeiro.Entities;
using Primeiro.Helpers;
using Primeiro.LoaderController;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LoaderAction> listAction = new List<LoaderAction>();
            listAction.Add(new LoaderAction("Exemplo Capitulo 1 - Teste para conhecimento", typeof(ExemploController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 3 - Triangulo", typeof(TrianguloController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 5 - Conta Bancária", typeof(ContaBancariaController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 6 - Exemplo de structs", typeof(ExemplosController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 6 - Desafio de listas", typeof(DesafioListaController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 7 - Manipulação de strings", typeof(StringTestController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 7 - DateTime e TimeSpan", typeof(DateTimeAndTimeSpanController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 9 - Exemplo de Enums", typeof(OrderController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 9 - Exemplo de Contratos", typeof(ContractController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 9 - Exemplo de Posts", typeof(StringBuilderController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 9 - Desafio Ordem de pedido", typeof(DesafioController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 10 - Exemplo de herança", typeof(ExemploHerancaController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 10 - Exemplo de polimorfismo", typeof(ExemploPolimorfismoController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 10 - Desafio de polimorfismo", typeof(DesafioPolimorfismoController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 10 - Desafio de classe abstrata", typeof(DesafioClasseAbstrataController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 11 - Exemplo de custom exception", typeof(ExemploCustomExceptionsController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 13 - Exemplo de Locadora sem Interface", typeof(ExemploLocadoraSemInterfaceController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 13 - Exemplo de Locadora com Interface", typeof(ExemploLocadoraComInterfaceController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 13 - Desafio de contrato", typeof(DesafioInterfaceController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 13 - Exemplo de FileStream", typeof(ExemploFileStreamController).ToString())); 
            listAction.Add(new LoaderAction("Exemplo Capitulo 14 - Exemplo Icomparable Ordenação", typeof(ExemploIcomparableController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 15 - Exemplo Generics ( Reuso )", typeof(ExemploGenericsController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 15 - Exemplo Limitacao de Generics ( Reuso )", typeof(ExemploRestricaoGenericController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 15 - Exemplo Equals e Hashcode", typeof(ExemploEqualsEHashCodeController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 15 - Exemplo de HashSet e SortedSet", typeof(ExemploHashSetSortedSetController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 15 - Desafio de Hashset", typeof(DesafioHashSetController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 15 - Exemplo de Dictionary e SortedDictionary", typeof(ExemploDictionaryController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 15 - Desafio de Dictionary e SortedDictionary", typeof(DesafioDictionaryController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 16 - Exemplo de Extension Methods", typeof(ExemploExtensionMethodsController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 17 - Exemplo Comparison", typeof(ExemploComparisonController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 17 - Exemplo Delegate", typeof(ExemploDelegateController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 17 - Exemplo Delegate Predicate", typeof(ExemploPredicateController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 17 - Exemplo Delegate Action", typeof(ExemploActionController).ToString()));            
            listAction.Add(new LoaderAction("Exemplo Capitulo 17 - Exemplo Delegate Func", typeof(ExemploFuncController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 17 - Exemplo do LINK", typeof(ExemploLinkController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 17 - Exercício LINK", typeof(ExercicioLinqController).ToString()));
            listAction.Add(new LoaderAction("Exemplo Capitulo 17 - Desafio LINK", typeof(DesafioLinqController).ToString()));
            


            listAction.Add(new LoaderAction("Limpar Console", "-1"));
            listAction.Add(new LoaderAction("Encerrar", null));

            int runOpt = -1;

            do
            {
                try
                {
                    Console.WriteLine("O que deseja rodar:");
                    for (int i = 0; i < listAction.Count; i++)
                    {
                        Console.WriteLine((i+1) + "." + listAction[i].Title);
                    }

                    runOpt = int.Parse(FunctionsHelper.getFromConsole("Digite uma opção: "));
                    if (runOpt > listAction.Count) // considerar o caso encerrar
                        throw new Exception("Escolha uma opção válida");
                    else if (runOpt <= listAction.Count)
                    {
                        if (listAction[runOpt - 1].Controller == "-1")
                        {
                            Console.Clear();
                            runOpt = -1;
                        }
                        else if (listAction[runOpt - 1].Controller == null)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Hell Yeahh, good bye!!");
                        }
                        else
                        {
                            LoadController controller = (LoadController)listAction[runOpt - 1].CreateInstance();
                            Console.WriteLine("");
                            controller.Rodar();
                            runOpt = -1;
                            Console.WriteLine("");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine($"Digite uma opção válida, escolha entre 1 e {listAction.Count}", listAction.Count + 1);
                    Console.WriteLine("");
                    runOpt = -1;
                }
            } while (runOpt == -1);
        }
    }
}