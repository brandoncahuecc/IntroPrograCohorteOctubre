using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7Consola.Clases
{
    public abstract class Personaje
    {
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public int Vidas { get; set; }

        public Personaje(string nombre, string genero)
        {
            Nombre = nombre;
            Genero = genero;
            Vidas = 1;
            Console.WriteLine($"{Nombre} ha ingresado al juego con {Vidas} vidas");
        }

        public Personaje(string nombre, string genero, int vidas)
        {
            Nombre = nombre;
            Genero = genero;
            Vidas = vidas;
            Console.WriteLine($"{Nombre} ha ingresado al juego con {Vidas} vidas");
        }

        ~Personaje()
        {
            Console.WriteLine($"{Nombre} ha salido del juego");
        }

        public void SumarVida()
        {
            Vidas++;
            Console.WriteLine($"{Nombre} ha conseguido una vida. Vidas: {Vidas}");
        }

        public void RestarVida()
        {
            Vidas--;
            Console.WriteLine($"{Nombre} ha perdido una vida. Vidas restastes: {Vidas}");
        }

        public abstract void Mover();
    }
}
