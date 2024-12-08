using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8Consola
{
    public class Almacenamiento<T>
    {
        public string Tabla { get; set; }
        public T Objeto { get; set; }
    }
}
