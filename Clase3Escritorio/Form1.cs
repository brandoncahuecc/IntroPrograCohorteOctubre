namespace Clase3Escritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            decimal nUno = 0;
            decimal nDos = 0;

            OperacionAritmetica operacion = new OperacionAritmetica();

            try
            {
                nUno = Convert.ToDecimal(numeroUno.Text);
                nDos = Convert.ToDecimal(numeroDos.Text);

                decimal suma = operacion.Suma(nUno, nDos);
                decimal resta = operacion.Resta(nUno, nDos);
                decimal multiplicacion = operacion.Multiplicacion(nUno, nDos);
                decimal division = operacion.Division(nUno, nDos);
                double potencia = operacion.Potencia(nUno);

                resultadoSuma.Text = suma.ToString();
                resultadoResta.Text = resta.ToString();
                resultadoMultiplicacion.Text = multiplicacion.ToString();
                resultadoDivision.Text = division.ToString();
                resultadoPotencia.Text = potencia.ToString();

                int numeroEntero = 4;
                decimal numeroDecimal = 0;
                string numeroString = string.Empty;

                numeroDecimal = numeroEntero;
                numeroString = numeroEntero.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tuvimos un problema: " + ex.Message);
            }
        }
    }
}
