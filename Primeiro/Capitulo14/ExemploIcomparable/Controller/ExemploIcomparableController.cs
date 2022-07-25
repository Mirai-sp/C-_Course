using System;
using System.Collections.Generic;
using System.Text;
using Primeiro.Entities;
using Primeiro.Capitulo14.ExemploIcomparable.Entities;

namespace Primeiro.LoaderController
{
    class ExemploIcomparableController : LoadController
    {
        public override void Rodar()
        {
            void printList(List<Employee> employeeList)
            {
                foreach (Employee emp in employeeList)
                    Console.WriteLine(emp);
            }

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee("Maria Brown,4300.00"));
            employeeList.Add(new Employee("Alex Green,3100.00"));
            employeeList.Add(new Employee("Bob Grey,3100.00"));
            employeeList.Add(new Employee("Alex Black,2450.00"));
            employeeList.Add(new Employee("Eduardo Rose,4390.00"));
            employeeList.Add(new Employee("Willian Red,2900.00"));
            employeeList.Add(new Employee("Marta Blue,6100.00"));
            employeeList.Add(new Employee("Alex Brown,5000.00"));


            Console.WriteLine("Exemplo IComparable - Ordenação");
            Console.WriteLine();

            Console.WriteLine("Lista não ordenada");
            printList(employeeList);

            Console.WriteLine();
            Console.WriteLine("Lista ordenada");
            employeeList.Sort(); // deve implementar a interface IComparable para usar.
            printList(employeeList);
        }
    }
}
