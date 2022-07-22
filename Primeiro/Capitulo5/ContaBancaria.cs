using System;
using System.Globalization;

namespace Primeiro.LoaderController
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome)
        {
            this.Numero = numero;
            this.Nome = nome;
        }

        public ContaBancaria(int numero, string nome, double valorDeposito) : this(numero, nome)
        {
            Depositar(valorDeposito);
        }

        public void Depositar(double valorDeposito)
        {
            if (valorDeposito <= 0)
                throw new Exception("Valor depositado não pode ser menor ou igual a 0.");

            this.Saldo += valorDeposito;
        }

        public void Sacar(double valorSaque)
        {
            double valorSacado = Saldo - valorSaque - 5.00;
            if (valorSacado < 0)
                throw new Exception("Não é possível efetuar o saque, pois o valor excede o saldo disponível.");
            this.Saldo = valorSacado;
        }

        public override string ToString()
        {
            return "Conta " + Numero +
                    ", Titular: " + Nome + 
                    ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
