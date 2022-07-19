using System;
using Primeiro.Capitulo2;
using Primeiro.Capitulo3;
using Primeiro.Capitulo5;
using Primeiro.Capitulo6;
using Primeiro.Capitulo9.ExemploEnums.Controller;
using Primeiro.Capitulo9.ExemploContratos.Controller;
using Primeiro.Capitulo9.ExemploStringBuilder.Controller;
using Primeiro.Capitulo9.DesafioPedido.Controller;
using Primeiro.Capitulo10.ExemploHeranca.Controller;
using Primeiro.Capitulo10.ExemploPolimorfismo.Controller;
using Primeiro.Capitulo10.DesafioPolimorfismo.Controller;
using Primeiro.Capitulo10.DesafioClasseAbstrata.Controller;


namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            void EfetuarEscolha(ref int runOpt, Action functionRun)
            {
                functionRun();
                runOpt = -1;
                Console.WriteLine();
            }


            int runOpt = -1;
            const int maxOpt = 13;
            const int endOpt = maxOpt + 1;
            Console.WriteLine("O que deseja rodar:");
            while (runOpt == -1)
            {
                Console.WriteLine("1. Exemplo Capitulo 1 - Teste para conhecimento");
                Console.WriteLine("2. Exemplo Capitulo 3 - Triangulo");
                Console.WriteLine("3. Exemplo Capitulo 5 - Conta Bancária");
                Console.WriteLine("4. Exemplo Capitulo 6 - Manipulação de strings");
                Console.WriteLine("5. Exemplo Capitulo 6 - DateTime e TimeSpan");
                Console.WriteLine("6. Exemplo Capitulo 9 - Exemplo de Enums");
                Console.WriteLine("7. Exemplo Capitulo 9 - Exemplo de Contratos");
                Console.WriteLine("8. Exemplo Capitulo 9 - Exemplo de Posts");
                Console.WriteLine("9. Exemplo Capitulo 9 - Desafio Ordem de pedido");
                Console.WriteLine("10. Exemplo Capitulo 10 - Exemplo de herança");
                Console.WriteLine("11. Exemplo Capitulo 10 - Exemplo de polimorfismo");
                Console.WriteLine("12. Exemplo Capitulo 10 - Desafio de polimorfismo");
                Console.WriteLine("13. Exemplo Capitulo 10 - Desafio de classe abstrata");
                Console.WriteLine(endOpt + ". Encerrar");
                Console.Write("Digite a opção desejada: ");

                try
                {
                    runOpt = int.Parse(Console.ReadLine());
                    if (!(runOpt >= 1 && runOpt <= maxOpt + 1))
                        throw new Exception("Escolha um numero válido");

                    switch (runOpt)
                    {
                        case 1:
                            EfetuarEscolha(ref runOpt, Exemplo.Rodar);
                            break;
                        case 2:
                            EfetuarEscolha(ref runOpt, TrianguloController.Rodar);
                            break;
                        case 3:
                            EfetuarEscolha(ref runOpt, ContaBancariaController.Rodar);
                            break;
                        case 4:
                            EfetuarEscolha(ref runOpt, StringTest.Rodar);
                            break;
                        case 5:
                            EfetuarEscolha(ref runOpt, DateTimeAndTimeSpan.Rodar);
                            break;
                        case 6:
                            EfetuarEscolha(ref runOpt, OrderController.Rodar);
                            break;
                        case 7:
                            EfetuarEscolha(ref runOpt, ContractController.Rodar);
                            break;
                        case 8:
                            EfetuarEscolha(ref runOpt, StringBuilderController.Rodar);
                            break;
                        case 9:
                            EfetuarEscolha(ref runOpt, DesafioController.Rodar);
                            break;
                        case 10:
                            EfetuarEscolha(ref runOpt, ExemploHerancaController.Rodar);
                            break;
                        case 11:
                            EfetuarEscolha(ref runOpt, ExemploPolimorfismoController.Rodar);
                            break;
                        case 12:
                            EfetuarEscolha(ref runOpt, DesafioPolimorfismoController.Rodar);
                            break;
                        case 13:
                            EfetuarEscolha(ref runOpt, DesafioClasseAbstrataController.Rodar);
                            break;
                        case endOpt:
                            Console.WriteLine();
                            Console.WriteLine("Hell Yeahh, good bye!!");
                            break;
                    }
                }
                catch (Exception e)
                {
                    runOpt = -1;
                    Console.WriteLine("Digite uma opção válida, escolha entre 1 e {0}", maxOpt);
                }
            }
        }
    }
}