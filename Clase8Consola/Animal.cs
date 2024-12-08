using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8Consola
{
    public class Animal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public decimal Peso { get; set; }

        public Animal()
        {

        }

        public Animal(int id, string nombre, string raza, decimal peso)
        {
            Id = id;
            Nombre = nombre;
            Raza = raza;
            Peso = peso;
        }

        public override string ToString()
        {
            return $"Id: {Id} - Nombre: {Nombre} - Raza: {Raza} - Peso: {Peso}";
        }
    }
}
