using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7Consola.Clases
{
    public sealed class Browser : Personaje
    {
        public Browser() : base("Browser", "M", 6)
        {
        }

        public override void Mover()
        {
            Console.WriteLine($"{Nombre} esta avanzando y lanzando fuego");
        }
    }
}
