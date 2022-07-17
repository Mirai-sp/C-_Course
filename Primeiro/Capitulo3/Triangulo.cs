using System;
using System.Globalization;

namespace Primeiro.Capitulo3
{

    public class Triangulo
    {
        private double _a;
        private double _b;
        private double _c;
        public string ExemploReadOnlyAutoProperty { get; private set; }
        public string ExemploAutoProperty { get; set; }

        public Triangulo()
        {
            this._a = 0;
            this._b = 0;
            this._c = 0;
            this.ExemploAutoProperty = "Valor Default, AutoProperty só pode ser usado em metodos get e set que nao possuem customização";
            this.ExemploReadOnlyAutoProperty = "Pode ser lido mas nao modificado";
        }

        // Conceito de property, eliminando assim criar metodos getters e setters, inclusive no método set é totalmente possível implementar uma lógica de atribuição
        // Inclusive uma property pode ter somente o metodo get ou set
        public double A
        {
            get { return this._a; }
            set { this._a = value; }
        }

        public double B
        {
            get { return this._b; }
            set { this._b = value; }
        }

        public double C
        {
            get { return this._c; }
            set { this._c = value; }
        }

        public double CalcularArea()
        {
            double p = (this.A + this.B + this.C) / 2.0;
            double area = Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
            return area;
        }

        public override string ToString()
        {
            return "Lado A:" + A.ToString("F4", CultureInfo.InvariantCulture) +
                   " Lado B: " + B.ToString("F4", CultureInfo.InvariantCulture) +
                   " Lado C: " + C.ToString("F4", CultureInfo.InvariantCulture) +
                   " Area: " + CalcularArea().ToString("F4", CultureInfo.InvariantCulture);
        }
    }
}
