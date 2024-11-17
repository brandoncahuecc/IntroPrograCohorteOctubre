using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Consola.Iterancion
{
    public class Ciclo
    {

        public void CicloFor()
        {
            for (int i = 0; i < 25; i += 2)
            {
                Console.WriteLine(i + 1);
            }
        }

        public void CicloFor(int recorridos)
        {
            for (int i = 0; i < recorridos; i += 2)
            {
                Console.WriteLine(i + 1);
            }
        }

        public bool CicloWhile()
        {
            int x = 100;

            while (x < 110)
            {
                Console.WriteLine(x);
                x++;
            }

            return true;
        }

        public bool CicloDoWhile()
        {
            int x = 100;

            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 110);

            return true;
        }

        public void CicloWhile(bool esTrue = false)
        {
            while (esTrue)
            {
                Console.WriteLine("While Ejecutado");
                esTrue = false;
            }
        }

        public void CicloDoWhile(bool esTrue = false)
        {
            do
            {
                Console.WriteLine("Do While Ejecutado");
                esTrue = false;
            } while (esTrue);
        }

        public string[] ObtenerArreglo()
        {
            string[] cadenas = new string[6];

            cadenas[0] = "A";
            cadenas[1] = "E";
            cadenas[2] = "I";
            cadenas[3] = "O";
            cadenas[4] = "U";

            return cadenas;
        }

        public void ImprimirArregloFor(string[] cadenas)
        {
            for (int i = 0; i < cadenas.Length; i++)
            {
                Console.WriteLine(cadenas[i] ?? "No Value");
            }
        }

        public void ImprimirArregloForeach(string[] cadenas)
        {
            foreach (string item in cadenas)
            {
                Console.WriteLine(item ?? "No Value");
            }
        }

        public List<string> ObtenerLista()
        {
            List<string> nombres = new() { "Brandon", "Alexander", "Alejandro", "Estuardo", "Mario" };
            return nombres;
        }

        public void ImprimirListaForeach(List<string> nombres)
        {
            foreach (string item in nombres)
            {
                Console.WriteLine(item ?? "No Value");
            }
        }

        public void ImprimirListaForEach(List<string> nombres)
        {
            nombres.ForEach(item =>
            {
                Console.WriteLine(item);
                //Console.WriteLine("-----------");
            });
        }

        public void TipoParametros(string valor, ref string referencia, out string salida, string opcional = "Default")
        {
            valor = "Cambie el valor";
            referencia = "Cambie la referencia";
            salida = "Cambie la salida";
            opcional = "Cambie el opcional";

            Console.WriteLine("********************************");
            Console.WriteLine("Dentro de TipoParametros");
            Console.WriteLine("********************************");
            Console.WriteLine($"Valor = {valor}");
            Console.WriteLine($"Referencia = {referencia}");
            Console.WriteLine($"salida = {salida}");
            Console.WriteLine($"opciona = {opcional}");
        }

    }
}
