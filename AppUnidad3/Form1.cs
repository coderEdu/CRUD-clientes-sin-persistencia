using AppUnidad3.Views.ViewCliente;

namespace AppUnidad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormulario<FormularioCliente>();
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormulario<ListaCliente>();
        }

        private void LoadFormulario<T>() where T : Form, new()      // generic method
        {
            Form? formulario = pnlMaster.Controls.OfType<T>().FirstOrDefault();

            if (formulario != null) 
            {
                if (formulario.WindowState == FormWindowState.Minimized) 
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                formulario.BringToFront();
            }

            formulario = new T();
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            pnlMaster.Controls.Add(formulario);
            formulario.Show();
        }
    }
}
