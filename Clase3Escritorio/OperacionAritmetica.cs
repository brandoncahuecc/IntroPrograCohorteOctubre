using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3Escritorio
{
    internal class OperacionAritmetica
    {


        public decimal Suma(decimal numeroUno, decimal numeroDos)
        {
            decimal resultado = numeroUno + numeroDos;
            return resultado;
        }

        public decimal Resta(decimal numeroUno, decimal numeroDos)
        {
            decimal resultado = numeroUno - numeroDos;
            return resultado;
        }

        public decimal Multiplicacion(decimal numeroUno, decimal numeroDos)
        {
            decimal resultado = numeroUno * numeroDos;
            return resultado;
        }

        public decimal Division(decimal numeroUno, decimal numeroDos)
        {
            //bool condicional = numeroDos != 0 ? true : false;

            //if (condicional)
            //{
            //    decimal resultado = numeroUno / numeroDos;
            //    return resultado;
            //}

            //return 0;

            decimal resultado = numeroDos == 0 ? 0 : numeroUno / numeroDos;
            return resultado;
        }

        public double Potencia(decimal numeroUno)
        {
            double resultado = Math.Pow((double)numeroUno, 3);
            return resultado;
        }

    }
}
