using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6Consola.Clases
{
    public class FiguraGeometrica
    {
        //Propiedades
        public string Nombre { get; set; }

        //Metodos
        public FiguraGeometrica()
        {
            Nombre = string.Empty;
        }

        public FiguraGeometrica(string nombre)
        {
            Nombre = nombre;
        }

        //Eventos
        public virtual double CalcularArea()
        {
            return 0;
        }

        public virtual double CalcularPerimetro()
        {
            return 0;
        }
    }
}
