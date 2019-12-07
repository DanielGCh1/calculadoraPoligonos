using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Cuadrado : Figura
    {
        //private double largoLado;


        //public double LargoLado
        //{
        //    get { return this.largoLado; }
        //    set { this.largoLado = value; }


        //}

        public double Lado
        {
            get;
            set;

        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return this.Lado * 4;
        }
    }
}