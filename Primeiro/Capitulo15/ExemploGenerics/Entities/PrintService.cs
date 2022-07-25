using System;

namespace Primeiro.Capitulo15.ExemploGenerics.Entities
{
    class PrintService<MyGeneric> // Generic declarado como MyGeneric - pode ser qualquer nome, observe inclusive o tipo de retorno das funcoes como a First()
    {

        private MyGeneric[] _values = new MyGeneric[10];
        private int _count = 0;

        public void AddValue(MyGeneric value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public MyGeneric First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
