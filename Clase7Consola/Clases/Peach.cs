using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7Consola.Clases
{
    public class Peach : Personaje
    {
        public Peach() : base("Peach", "F", 2)
        {

        }

        public override void Mover()
        {
            Console.WriteLine($"{Nombre} está caminando");
        }
    }
}
