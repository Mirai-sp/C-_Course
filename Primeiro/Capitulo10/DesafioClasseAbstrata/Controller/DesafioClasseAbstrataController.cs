using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using Primeiro.Capitulo10.DesafioClasseAbstrata.Entities;
using Primeiro.Entities;
using Primeiro.Helpers;

namespace Primeiro.Capitulo10.DesafioClasseAbstrata.Controller
{
    class DesafioClasseAbstrataController : LoadController
    {
        public override void Rodar()
        {
            int numEmployee = int.Parse(FunctionsHelper.getFromConsole("Enter the number of tax payers: "));
            List<Contribuinte> contribuintes = new List<Contribuinte>();

            for (int i = 1; i <= numEmployee; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                char kind = char.Parse(FunctionsHelper.getFromConsole("Individual or company (i/c)?: ").ToLower());
                string name = FunctionsHelper.getFromConsole("Name: ");
                double anualIncome = double.Parse(FunctionsHelper.getFromConsole("Anual income: "));
                if (kind == 'c')
                {
                    int employeeNumber = int.Parse(FunctionsHelper.getFromConsole("Number of employees: "));
                    contribuintes.Add(new PessoaJuridica(name, anualIncome, employeeNumber));
                }
                else
                {
                    double healthExpenditures = double.Parse(FunctionsHelper.getFromConsole("Health expenditures: "));
                    contribuintes.Add(new PessoaFisica(name, anualIncome, healthExpenditures));
                }
            }

            double totalTax = 0;
            Console.WriteLine("Taxes Paid");            
            foreach (Contribuinte cont in contribuintes)
            {
                Console.WriteLine(cont.Nome + ": $ " + cont.TotalImposto().ToString("F2", CultureInfo.InvariantCulture));
                totalTax += cont.TotalImposto();
            }
            Console.WriteLine("Total Taxes: $ " + totalTax.ToString("F2", CultureInfo.InvariantCulture));            
        }
    }
}
