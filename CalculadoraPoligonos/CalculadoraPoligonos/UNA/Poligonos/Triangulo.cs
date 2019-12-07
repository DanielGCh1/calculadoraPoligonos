using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Triangulo : Figura
    {
        public double Lado1
        {
            get;
            set;
        }

        public double Lado2
        {
            get;
            set;
        }

        public double Lado3
        {
            get;
            set;
        }

        public double Base
        {
            get;
            set;
        }

        public double Altura
        {
            get;
            set;
           
        }

        public override double CalcularArea()
        {
            return (this.Base * this.Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return this.Lado1 + this.Lado2 + this.Lado3;
        }
    }
}