using System;
using System.Globalization;
using Primeiro.Entities;

namespace Primeiro.LoaderController
{
    class ContaBancariaController : LoadController
    {
        public override void Rodar()
        {
            bool rodar = true;
            while (rodar)
            {
                ContaBancaria contaBancaria;
                int numeroConta = 0;
                string nomeTitular;
                bool hasError = false;
                do
                {
                    try
                    {
                        Console.Write("Informe o número da conta: ");
                        numeroConta = int.Parse(Console.ReadLine());
                        hasError = false;
                    }
                    catch
                    {
                        hasError = true;
                        Console.WriteLine("Informe um número de conta válido (Números inteiros)");
                    }
                } while (hasError);

                Console.Write("Informe o nome do titular da conta: ");
                nomeTitular = Console.ReadLine();

                Console.Write("Possui depósito inicial? (s/n): ");
                char temDepositoInicial = char.Parse(Console.ReadLine().ToLower());
                if (temDepositoInicial == 's')
                {
                    double saldoInicial = 0;
                    do
                    {
                        try
                        {
                            Console.WriteLine("Informe o valor do depósito inicial: ");
                            saldoInicial = double.Parse(Console.ReadLine());
                            hasError = false;
                        }
                        catch
                        {
                            hasError = true;
                            Console.WriteLine("Informe um valor válido para o depósito inicial");
                        }
                    } while (hasError);
                    contaBancaria = new ContaBancaria(numeroConta, nomeTitular, saldoInicial);
                }
                else
                {
                    contaBancaria = new ContaBancaria(numeroConta, nomeTitular);
                }

                Console.WriteLine("Escolha uma das opções");
                int escolhaOperacao = -1;
                while (escolhaOperacao == -1)
                {
                    Console.WriteLine("1. Depositar");
                    Console.WriteLine("2. Sacar");
                    Console.WriteLine("3. Saldo");
                    Console.WriteLine("4. Encerrar");
                    Console.Write("Escolha: ");

                    try
                    {
                        escolhaOperacao = int.Parse(Console.ReadLine());
                        if (!(escolhaOperacao >= 1 && escolhaOperacao <= 4))
                            throw new Exception("Escolha uma opção válida");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        escolhaOperacao = -1;
                    }

                    switch (escolhaOperacao)
                    {
                        case 1:
                            double valorDeposito = -1;
                            while (valorDeposito == -1)
                            {
                                try
                                {
                                    Console.Write("Informe o valor para depósito: ");
                                    valorDeposito = double.Parse(Console.ReadLine());
                                    contaBancaria.Depositar(valorDeposito);
                                }
                                catch
                                {
                                    Console.WriteLine("Informe um valor válido para depósito acima de zero");
                                    valorDeposito = -1;
                                }
                            }
                            escolhaOperacao = -1;
                            break;

                        case 2:
                            double valorSaque = -1;
                            while (valorSaque == -1)
                            {
                                try
                                {
                                    Console.Write("Informe o valor para saque: ");
                                    valorSaque = double.Parse(Console.ReadLine());
                                    contaBancaria.Sacar(valorSaque);
                                }
                                catch
                                {
                                    Console.WriteLine("O valor informado não é válido ou você não tem saldo para a operação");
                                    valorSaque = -1;
                                }
                            }
                            escolhaOperacao = -1;
                            break;
                        case 3:
                            Console.WriteLine("O saldo da conta é $: " + contaBancaria.Saldo.ToString("F2", CultureInfo.InvariantCulture));
                            escolhaOperacao = -1;
                            break;
                        case 4:
                            break;
                    }
                }

                Console.WriteLine(contaBancaria);

                Console.Write("Deseja informar outra conta? (s/n): ");
                rodar = char.Parse(Console.ReadLine().ToString().ToLower()) == 's';
            }
            Console.WriteLine("Good Bye!...");
        }
    }
}
