using System;
using System.Globalization;

namespace Primeiro
{
    namespace Capitulo2
    {        
        public class Triangulo
        {
            private double A;
            private double B;
            private double C;

            public Triangulo()
            {
                this.A = 0;
                this.B = 0;
                this.C = 0;
            }

            public double GetA()
            {
                return this.A;
            }
            public double GetB()
            {
                return this.B;
            }
            public double GetC()
            {
                return this.C;
            }
            public void SetA(double Value)
            {
                this.A = Value;
            }
            public void SetB(double Value)
            {
                this.B = Value;
            }
            public void SetC(double Value)
            {
                this.C = Value;
            }

            public double CalcularArea()
            {
                double p = (this.A + this.B + this.C) / 2.0;
                double area = Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
                return area;
            }

            public override string ToString()
            {
                return "Lado A:"   + A.ToString("F4", CultureInfo.InvariantCulture) +
                       " Lado B: " + B.ToString("F4", CultureInfo.InvariantCulture) + 
                       " Lado C: " + C.ToString("F4", CultureInfo.InvariantCulture) + 
                       " Area: " + CalcularArea().ToString("F4", CultureInfo.InvariantCulture);
            }
        }
    }
}