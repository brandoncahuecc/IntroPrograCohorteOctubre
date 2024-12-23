﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6Consola.Clases
{
    public class Circulo : FiguraGeometrica
    {
        public double Radio { get; set; }

        public Circulo(string nombre, double radio) : base(nombre)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}
