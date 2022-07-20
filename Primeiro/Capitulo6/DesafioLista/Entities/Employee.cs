using System.Globalization;
using System.Text;

namespace Primeiro.Capitulo6.DesafioLista.Entities
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee()
        {

        }
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary (double percentage)
        {
            if (percentage > 0)
                Salary *= 1 + (percentage / 100);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Id).Append(", ").Append(Name).Append(", ").AppendLine(Salary.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
