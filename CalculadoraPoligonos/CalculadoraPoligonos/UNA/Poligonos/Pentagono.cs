using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Pentagono : Figura
    {
        public double Lado
        {
            get;
            set;
        }

        public override double CalcularArea()
        {
            return 5 * (Lado * 2) / 4 * System.Math.Tan(System.Math.PI/5);
        }

        public override double CalcularPerimetro()
        {
            return 5 * this.Lado;
        }
    }
}