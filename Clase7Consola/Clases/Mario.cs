using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7Consola.Clases
{
    public sealed class Mario : Personaje, IHabilidadEspecial
    {
        public Mario() : base("Mario", "M", 3)
        {

        }

        public override void Mover()
        {
            Console.WriteLine($"{Nombre} está corriendo y saltando");
        }

        public void UsarHabilidadEspecial()
        {
            Console.WriteLine($"{Nombre} usa el poder del crecimiento al comer un hongo");
        }
    }
}
