namespace Primeiro.Capitulo10.ExemploHeranca.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) // sealed evita que metodos sobreescritos ou caso seja declarado na classe base, que a mesma não seja herdada ou sobreescrita
        {
            // caso quiser executar o método da classe base e por exemplo descontar um taxa de 2 rs por exemplo
            // base.Withdraw(amount);
            // Balance -= 2.0;
            Balance -= amount;
        }
    }
}