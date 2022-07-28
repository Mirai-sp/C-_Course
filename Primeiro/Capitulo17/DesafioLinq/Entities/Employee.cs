using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Primeiro.Capitulo17.DesafioLinq.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Email: " + Email + ", Salary: " + Salary.ToString("F2", CultureInfo.InvariantCulture);            
        }
    }
}
