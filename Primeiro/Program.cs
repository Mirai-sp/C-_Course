using System;
using System.Collections.Generic;
using Primeiro.Entities;
using Primeiro.Helpers;
using Primeiro.Capitulo2;
using Primeiro.Capitulo3;
using Primeiro.Capitulo5;
using Primeiro.Capitulo6.Exemplos.Controller;
using Primeiro.Capitulo6.DesafioLista.Controller;
using Primeiro.Capitulo7;
using Primeiro.Capitulo9.ExemploEnums.Controller;
using Primeiro.Capitulo9.ExemploContratos.Controller;
using Primeiro.Capitulo9.ExemploStringBuilder.Controller;
using Primeiro.Capitulo9.DesafioPedido.Controller;
using Primeiro.Capitulo10.ExemploHeranca.Controller;
using Primeiro.Capitulo10.ExemploPolimorfismo.Controller;
using Primeiro.Capitulo10.DesafioPolimorfismo.Controller;
using Primeiro.Capitulo10.DesafioClasseAbstrata.Controller;
using Primeiro.Capitulo11.ExemploCustomExceptions.Controller;


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