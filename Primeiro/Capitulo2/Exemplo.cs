using System;
using System.Globalization;

namespace Primeiro.Capitulo2
{
    public class Exemplo
    {
        public void Rodar()
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            bool success = false;

            // Metodo Placeholder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            // Metodo de interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            // Metodo via concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");

            // Para nao aplicar regionalizacao no ponto decimal e usar ponto ao invez de virgula
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            // tomar cuidado com divisoes, se for numero inteiro a divisao sera inteira
            double resultado = 10f / 2f;
            Console.WriteLine(resultado);
            
            // Fazer conversao de dado
            while (!success)
            {
                try
                {
                    Console.WriteLine("Digite um número");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Você digitou {0}", n1);
                    success = true;
                }
                catch
                {
                    Console.WriteLine("O número digitado é inválido, tente novamente");
                }
            }
        }
    }
}
