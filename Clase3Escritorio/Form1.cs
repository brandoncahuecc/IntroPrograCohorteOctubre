namespace Clase3Escritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AsignarNombre();
        }

        private void AsignarNombre()
        {
            //char[] nombreCompletoChar = { 'B', 'r', 'a', 'n', 'd', 'o', 'n'};

            string nombreCompleto = "Brandon Cahuec";
            DateTime fechaNacimiento = Convert.ToDateTime("2000-01-10");

            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            bool esMayorEdad = edad > 17 ? true : false;

            if (esMayorEdad)
            {
                //Solicitar DPI y RTU
            }
            else
            {
                //Solicitar partida de nacimiento y DPI de los padres
            }

            string textoMayorEdad = esMayorEdad ? "Mayor de Edad" : "Menor de Edad";

            lblNombreCompleto.Text = nombreCompleto
                + "\n" + fechaNacimiento.ToString("dd/MM/yyyy")
                + "\n" + textoMayorEdad;
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
