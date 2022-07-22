using Primeiro.Capitulo14.ExemploLocadora.ComInterface.Interface;

namespace Primeiro.Capitulo14.ExemploLocadora.ComInterface.Services
{
    class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}