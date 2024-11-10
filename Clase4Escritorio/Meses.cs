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
    public partial class Meses : Form
    {
        public Meses()
        {
            InitializeComponent();
        }

        private void ejecutar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMes.Text, out int mes))
            {
                txtMes.Focus();
                MessageBox.Show($"Debes de ingresar solo números\r\nIngresaste: {txtMes.Text}");
                return;
            }

            if (mes < 1 || mes > 12)
            {
                txtMes.Focus();
                MessageBox.Show("Recuerda que solo tenemos 12 meses y debes de ingresar de 1 a 12");
                return;
            }

            switch (mes)
            {
                case 0:
                    MessageBox.Show("Cero");
                    break;
                case 1:
                    MessageBox.Show("Enero");
                    break;
                case 2:
                    MessageBox.Show("Febrero");
                    break;
                case 3:
                    MessageBox.Show("Marzo");
                    break;
                case 4:
                    MessageBox.Show("Abril");
                    break;
                case 5:
                    MessageBox.Show("Mayo");
                    break;
                case 6:
                    MessageBox.Show("Junio");
                    break;
                case 7:
                    MessageBox.Show("Julio");
                    break;
                case 8:
                    MessageBox.Show("Agosto");
                    break;
                case 9:
                    MessageBox.Show("Septiembre");
                    break;
                case 10:
                    MessageBox.Show("Octubre");
                    break;
                case 11:
                    MessageBox.Show("Noviembre");
                    break;
                case 12:
                    MessageBox.Show("Diciembre");
                    break;
                default:
                    MessageBox.Show("Mes no existe");
                    break;
            }

        }
    }
}
