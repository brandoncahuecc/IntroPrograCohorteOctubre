using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6Consola.Clases
{
    public class Rectangulo : FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo(string nombre, double bases, double altura) : base(nombre)
        {
            Base = bases;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return (2 * Base) + (2 * Altura);
        }
    }
}
