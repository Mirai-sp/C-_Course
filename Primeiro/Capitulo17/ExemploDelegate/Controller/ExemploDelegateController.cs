using System;
using System.Collections.Generic;
using System.Text;
using Primeiro.Entities;
using Primeiro.Capitulo17.ExemploDelegate.Service;

namespace Primeiro.LoaderController
{
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate void MultiCastBinaryNumericOperation(double n1, double n2);
    class ExemploDelegateController : LoadController
    {
        public override void Rodar()
        {
            Console.WriteLine("Exemplo de Delegate");

            double a = 10;
            double b = 12;
            // BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            // double result = op(a, b);
            double result = op.Invoke(a, b);
            Console.WriteLine(result);

            Console.WriteLine();
            Console.WriteLine("Exemplo de multicast Delegate - faz sentido em funcoes void, faz chamada na ordem de inclusao");
            MultiCastBinaryNumericOperation op2 = CalculationService.ShowSum;
            op2 += CalculationService.ShowMax;
            op2(a, b);
            //op2.Invoke(a, b);
        }
    }
}
