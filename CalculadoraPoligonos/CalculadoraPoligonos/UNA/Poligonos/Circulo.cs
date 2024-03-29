﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Circulo : Figura
    {
        public double Radio
        {
            get;
            set;
        }

        public override double CalcularArea()
        {
            return System.Math.PI * (System.Math.Pow(this.Radio, 2));
        }

        public override double CalcularPerimetro()
        {
            return (2*System.Math.PI )* this.Radio;
        }
    }
}