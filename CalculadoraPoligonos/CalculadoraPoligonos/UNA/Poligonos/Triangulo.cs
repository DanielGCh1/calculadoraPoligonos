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
            get => default;
            set
            {
            }
        }

        public double Lado2
        {
            get => default;
            set
            {
            }
        }

        public double Lado3
        {
            get => default;
            set
            {
            }
        }

        public double Base
        {
            get => default;
            set
            {
            }
        }

        public double Altura
        {
            get => default;
            set
            {
            }
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