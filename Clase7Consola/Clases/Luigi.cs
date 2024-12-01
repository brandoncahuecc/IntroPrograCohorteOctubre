using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7Consola.Clases
{
    public sealed class Luigi : Personaje, IHabilidadEspecial
    {
        public Luigi(string nombre, string genero, int vidas) : base(nombre, genero, vidas)
        {

        }

        public override void Mover()
        {
            Console.WriteLine($"{Nombre} está corriendo y flotando");
        }

        public void UsarHabilidadEspecial()
        {
            Console.WriteLine($"{Nombre} salta muy alto y da una patada al aire");
        }
    }
}
