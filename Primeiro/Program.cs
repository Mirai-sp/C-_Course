using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            // Metodo Placeholder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            
            // Metodo de interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            // Metodo via concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");

            // Para nao aplicar regionalizacao no ponto decimal e usar ponto ao invez de virgula
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}
