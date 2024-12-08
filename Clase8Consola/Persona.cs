using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8Consola
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona()
        {
            
        }

        public Persona(int id, string nombre, int edad)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public override string ToString()
        {
            return $"Id: {Id} - Nombre: {Nombre} - Edad: {Edad}";
        }
    }
}
