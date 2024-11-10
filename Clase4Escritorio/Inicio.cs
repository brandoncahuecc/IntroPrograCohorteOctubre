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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            ImprimirTexto();
        }

        public void ImprimirTexto()
        {
            string texto = "Generando facturas para el cliente \"ABC Group\"…\r\n\r\nFactura: 1021\t\t\tCompletado!\r\nFactura: 1022\t\t\tCompletado!\r\n\r\nDirectorio de salida:\r\nC:\\Facturas";

            string textoDos = @"Generando facturas para el cliente ""ABC Group""…

Factura: 1021           Completado!
Factura: 1022           Completado!

Directorio de salida:
C:\Facturas";

            string primerNombre = "Brandon";
            string segundoNombre = "A.";
            string primerApellido = "Cahuec";
            string segundoApellido = "C.";

            string nombreCompleto = "Mi nombre completo es " + primerNombre + " " + segundoNombre + " " + primerApellido + " " + segundoApellido;
            string nombreCompletoInterpolacion = $"Mi nombre completo es {primerNombre} {segundoNombre} {primerApellido} {segundoApellido}";

            textoSalida.Text = nombreCompletoInterpolacion;
        }
    }
}
