using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase4Escritorio
{
    public partial class Numeros : Form
    {
        public Numeros()
        {
            InitializeComponent();
        }

        private void validarMayor_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(noUno.Text, out int inputUno))
            {
                noUno.Focus();
                MessageBox.Show($"Debes de ingresar solo números\r\nIngresaste: {noUno.Text}");
                return;
            }

            if (!int.TryParse(noDos.Text, out int inputDos))
            {
                noDos.Focus();
                MessageBox.Show($"Debes de ingresar solo números\r\nIngresaste: {noDos.Text}");
                return;
            }

            if (!int.TryParse(noTres.Text, out int inputTres))
            {
                noTres.Focus();
                MessageBox.Show($"Debes de ingresar solo números\r\nIngresaste: {noTres.Text}");
                return;
            }

            if (inputUno == inputDos && inputUno == inputTres)
            {
                respuesta.Text = "Todos los números ingresados son iguales";
            }
            else if (inputUno >= inputDos && inputUno >= inputTres)
            {
                respuesta.Text = $"El número mayor es '{inputUno}'";
            }
            else if(inputDos >= inputUno && inputDos >= inputTres)
            {
                respuesta.Text = $"El número mayor es '{inputDos}'";
            }
            else if (inputTres >= inputUno && inputTres >= inputDos)
            {
                respuesta.Text = $"El número mayor es '{inputTres}'";
            }
            else
            {
                respuesta.Text = "No se pudo validar cual es el número mayor";
            }
        }
    }
}
