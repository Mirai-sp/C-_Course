using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Primeiro.Entities;
using Primeiro.Helpers;
using Primeiro.Capitulo17.DesafioLinq.Entities;


namespace Primeiro.LoaderController
{
    class DesafioLinqController : LoadController
    {
        public override void Rodar()
        {
            Console.WriteLine("Desafio do LINQ");
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee("Maria", "maria@gmail.com", 3200.00));
            employees.Add(new Employee("Alex", "alex@gmail.com", 1900.00));
            employees.Add(new Employee("Marco", "marco@gmail.com", 1700.00));
            employees.Add(new Employee("Bob", "bob@gmail.com", 3500.00));
            employees.Add(new Employee("Ana", "ana@gmail.com", 2800.00));

            double salary = double.Parse(FunctionsHelper.getFromConsole("Enter Salary: "), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Email of people whose salary is more than " + salary.ToString("F2", CultureInfo.InvariantCulture) + ":");
            var emailPeople = (from employer in employees
                               where employer.Salary > salary                               
                               orderby employer.Email
                               select employer.Email).ToList();
            emailPeople.ForEach(p => { Console.WriteLine(p); });

            var sumPeopleStartsWithM = (from employer in employees
                                        where employer.Name[0] == 'M'
                                        select employer.Salary).DefaultIfEmpty(0.00).Sum();

            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sumPeopleStartsWithM.ToString("F2", CultureInfo.InvariantCulture) + ":");
        }
    }
}
