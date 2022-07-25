using System;
using System.Collections.Generic;

namespace Primeiro.Capitulo15.ExemploRestricaoGenerics.Service
{
    class CalculationService
    {

        public T Max<T>(List<T> list) where T : IComparable // note que a classe nao foi declarada como generica, porem o metodo sim T(generico pode ser qualquer nome) entretanto tem um where onde exige que T(generico) implemente IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
