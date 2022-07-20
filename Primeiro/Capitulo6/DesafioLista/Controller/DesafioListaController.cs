using System;
using System.Collections.Generic;
using System.Globalization;
using Primeiro.Capitulo6.DesafioLista.Entities;
using Primeiro.Entities;
using Primeiro.Helpers;

namespace Primeiro.Capitulo6.DesafioLista.Controller
{
    class DesafioListaController : LoadController
    {
        public override void Rodar()
        {
            int numEmployee = int.Parse(FunctionsHelper.getFromConsole("How many employees will be registrated?: "));
            List<Employee> employeeList = new List<Employee>();

            for (int i = 1; i <= numEmployee; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                int employeeId = int.Parse(FunctionsHelper.getFromConsole("ID: "));
                string employeeName = FunctionsHelper.getFromConsole("Name: ");
                double employeeSalary = double.Parse(FunctionsHelper.getFromConsole("Salary: "), CultureInfo.InvariantCulture);

                employeeList.Add(new Employee(employeeId, employeeName, employeeSalary));
            }
            bool continueUpdating = false;
            do
            {
                int employeeId = int.Parse(FunctionsHelper.getFromConsole("Enter the employee id that will have salary increased: "));
                Employee foundEmployeed = employeeList.Find(x => x.Id == employeeId);
                if (foundEmployeed == null)
                    Console.WriteLine("This id does not exist!");
                else
                {
                    double percentage = double.Parse(FunctionsHelper.getFromConsole("Enter the percentage: "), CultureInfo.InvariantCulture);
                    foundEmployeed.IncreaseSalary(percentage);
                }

                continueUpdating = char.Parse(FunctionsHelper.getFromConsole("Continue updating? (s/n): ").ToLower()) == 's';
            } while (continueUpdating);

            Console.WriteLine("Updated list of employees:");
            foreach (Employee emp in employeeList)
                Console.WriteLine(emp);
        }
    }
}
