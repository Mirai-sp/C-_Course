using System;
using System.Globalization;
using Primeiro.Capitulo2;
using Primeiro.Capitulo3;
using Primeiro.Capitulo5;
using Primeiro.Capitulo6;
using Primeiro.Capitulo9.ExemploEnums.Entities;
using Primeiro.Capitulo9.ExemploEnums.Enums;
using Primeiro.Capitulo9.ExemploContratos.Entities;
using Primeiro.Capitulo9.ExemploContratos.Enums;


namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int runOpt = -1;
            const int maxOpt = 7;
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
                            RodarExemplo1();
                            runOpt = -1;
                            Console.WriteLine();
                            break;
                        case 2:
                            RodarExemplo2();
                            runOpt = -1;
                            Console.WriteLine();
                            break;
                        case 3:
                            RodarExemplo3();
                            runOpt = -1;
                            Console.WriteLine();
                            break;
                        case 4:
                            RodarExemplo4();
                            runOpt = -1;
                            Console.WriteLine();
                            break;
                        case 5:
                            RodarExemplo5();
                            runOpt = -1;
                            Console.WriteLine();
                            break;
                        case 6:
                            RodarExemplo6();
                            runOpt = -1;
                            Console.WriteLine();
                            break;
                        case 7:
                            RodarExemplo7();
                            runOpt = -1;
                            Console.WriteLine();
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

        public static void RodarExemplo1()
        {
            Exemplo exemplo = new Exemplo();
            exemplo.Rodar();
        }

        public static void RodarExemplo2()
        {
            Triangulo trianguloA = new Triangulo();
            trianguloA.A = 3;
            trianguloA.B = 4;
            trianguloA.C = 5;

            Triangulo trianguloB = new Triangulo();
            trianguloB.A = 7.50;
            trianguloB.B = 4.50;
            trianguloB.C = 4.02;

            /* é possível instanciar uma classe e já iniciar seus valores sem usar o construtor para isso usa-se { } mas as variaveis devem ser publicas pelos testes
            Triangulo TranguloC = new Triangulo
            {
                A = 7.50,
                B = 4.50,
                C = 4.02
            };
            */

            Console.WriteLine("As areas dos triangulos são: {0} e {1}", trianguloA.CalcularArea().ToString("F4", CultureInfo.InvariantCulture), trianguloB.CalcularArea().ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Triangulo A: " + trianguloA.ToString());
            Console.WriteLine("Triangulo B: " + trianguloB.ToString());
            Console.WriteLine("Lendo ReadOnlyAutoProperty: " + trianguloA.ExemploReadOnlyAutoProperty);
            trianguloA.ExemploAutoProperty = "Mudei a property";
            Console.WriteLine("Lendo AutoProperty: " + trianguloA.ExemploAutoProperty);
        }

        public static void RodarExemplo3()
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

        public static void RodarExemplo4()
        {
            StringTest stringTestObj = new StringTest();
            stringTestObj.Rodar();
        }

        public static void RodarExemplo5()
        {
            DateTimeAndTimeSpan dateTimeAndTimeSpantObj = new DateTimeAndTimeSpan();
            dateTimeAndTimeSpantObj.Rodar();
        }

        public static void RodarExemplo6()
        {
            Order order = new Order { 
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // converter enum para string
            String txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            // Converter string para enumerado
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }

        public static void RodarExemplo7()
        {
            Console.Write("Digite o nome do departamento: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Informe os dados do funcionário:");

            Console.Write("Informe o nome: ");
            string name = Console.ReadLine();

            Console.Write("Level ( Junior / MidLevel / Senior ): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Salário base: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("Quantos contratos para este trabalhador terá? ");
            int nContratos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nContratos; i++ )
            {
                Console.WriteLine($"Entre com os dados do contrato N#{i}");

                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duração (horas): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Entre com o mês e o ano para calcular o ganho (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int mounth = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Nome:" + worker.Name);
            Console.WriteLine("Departamento:" + worker.Department.Name);
            Console.WriteLine("Ganho em " + monthAndYear + " : " + worker.Income(mounth, year).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}