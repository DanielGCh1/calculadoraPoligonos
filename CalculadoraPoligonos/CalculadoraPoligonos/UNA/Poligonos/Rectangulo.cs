using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Rectangulo : Figura
    {
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
            return this.Altura * 2 + this.Base * 2;
        }

        public override double CalcularPerimetro()
        {
            return this.Altura * this.Base;
        }
    }
}