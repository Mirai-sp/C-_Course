using System;
using Primeiro.Capitulo9.ExemploContratos.Entities;
using Primeiro.Capitulo9.ExemploContratos.Enums;
using System.Globalization;


namespace Primeiro.Capitulo9.ExemploContratos.Controller
{
    class ContractController
    {
        public static void Rodar()
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

            for (int i = 1; i <= nContratos; i++)
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
