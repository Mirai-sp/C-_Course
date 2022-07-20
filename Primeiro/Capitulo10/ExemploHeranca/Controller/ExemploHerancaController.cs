using System;
using Primeiro.Capitulo10.ExemploHeranca.Entities;
using Primeiro.Helpers;
using Primeiro.Entities;

namespace Primeiro.Capitulo10.ExemploHeranca.Controller
{
    class ExemploHerancaController : LoadController
    {
        public override void Rodar()
        {
            // AULA sore herança
            bool rodar = false;

            rodar = char.Parse(FunctionsHelper.getFromConsole("Rodar Exemplo sobre herança (s/n): ").ToLower()) == 's';
            if (rodar)
            {
                BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
                Console.WriteLine(account.Balance);
            }

            rodar = char.Parse(FunctionsHelper.getFromConsole("Rodar Exemplo sobre upcasting/downcasting (s/n): ").ToLower()) == 's';
            if (rodar)
            {

                // AULA SOBRE UPCASTING E DOWNCASTING
                Account acc = new Account(1001, "Alex", 0.0);
                BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

                // UPCASTING

                Account acc1 = bacc;
                Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
                Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

                // DOWNCASTING

                BusinessAccount acc4 = (BusinessAccount)acc2;
                acc4.Loan(100.0);

                // BusinessAccount acc5 = (BusinessAccount)acc3;
                if (acc3 is BusinessAccount)
                {
                    //BusinessAccount acc5 = (BusinessAccount)acc3;
                    BusinessAccount acc5 = acc3 as BusinessAccount;
                    acc5.Loan(200.0);
                    Console.WriteLine("Loan!");
                }

                if (acc3 is SavingsAccount)
                {
                    //SavingsAccount acc5 = (SavingsAccount)acc3;
                    SavingsAccount acc5 = acc3 as SavingsAccount;
                    acc5.UpdateBalance();
                    Console.WriteLine("Update!");
                }
            }

            rodar = char.Parse(FunctionsHelper.getFromConsole("Rodar Exemplo sobre sobrescrita de método (s/n): ").ToLower()) == 's';
            if (rodar)
            {
                Account acc1 = new Account(1001, "Alex", 500.0);
                Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

                acc1.Withdraw(10.0);
                acc2.Withdraw(10.0);

                Console.WriteLine(acc1.Balance);
                Console.WriteLine(acc2.Balance);
            }
        }
    }
}
