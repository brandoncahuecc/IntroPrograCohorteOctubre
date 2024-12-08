namespace Clase4Escritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>()
            {
                "Brandon",
                "Curso",
                "Laboratorio"
            };

            Administracion administracion = new Administracion(lista);
            administracion.Show(this);
            administracion.Tag = this;
            this.Hide();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            Pagos pagos = new Pagos();
            pagos.Show(this);
            pagos.Tag = this;
            this.Hide();
        }
    }
}
