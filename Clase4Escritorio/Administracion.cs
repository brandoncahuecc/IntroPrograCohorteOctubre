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
    public partial class Administracion : Form
    {
        private List<string> _lista;

        public Administracion(List<string> lista)
        {
            InitializeComponent();
            _lista = lista;
            ImprimaLista();
        }

        private void ImprimaLista()
        {
            txtMostrarLista.Text = string.Join("\r\n", _lista);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 menu = (Form1)this.Tag;
            menu.Show();
            this.Close();
        }
    }
}
