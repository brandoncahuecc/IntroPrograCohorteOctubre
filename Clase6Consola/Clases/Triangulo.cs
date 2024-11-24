using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6Consola.Clases
{
    public class Triangulo : FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(string nombre, double bases, double altura) : base(nombre)
        {
            Base = bases;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            double ladoResultante = Math.Sqrt(Math.Pow(Base / 2, 2) + Math.Pow(Altura, 2));

            return Base + (2 * ladoResultante);
        }

        public string DevolverBase()
        {
            return Base.ToString();
        }
    }
}
