using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppUnidad3.Modelo;
using AppUnidad3.Services;

namespace AppUnidad3.Views.ViewCliente
{
    public partial class FormularioCliente : Form
    {
        private Cliente cliente = null;

        public FormularioCliente()
        {
            InitializeComponent();
            this.LoadNacionalidades();
        }

        public FormularioCliente(Cliente cliente)
        {
            InitializeComponent();
            this.LoadNacionalidades();
            this.cliente = cliente;
            this.LoadDataCliente();
        }

        private void LoadDataCliente()
        {
            if (this.cliente != null)
            {
                txtNombre.Text = this.cliente.Nombre;
                txtApellido.Text = this.cliente.Apellido;
                cboNac.SelectedItem = this.cliente.Nacionalidad;
            }
        }

        private void LoadNacionalidades()
        {
            List<string> lstNacionalidades = new List<string>();
            lstNacionalidades.Add("Argentina");
            lstNacionalidades.Add("Brazilera");
            lstNacionalidades.Add("Chilena");

            cboNac.DataSource = lstNacionalidades;
        }

        private void FormularioCliente_Load(object sender, EventArgs e)
        {

        }

        private void ClearData()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            this.cliente = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Falta ingresar el nombre del cliente");
                return;
            }

            if (String.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Falta ingresar el apellido del cliente");
                return;
            }

            if (this.cliente == null)   // new client
            {
                Cliente nuevoCliente = new Cliente();
                nuevoCliente.ID = Convert.ToInt32(ClienteService.GetListaCliente().Count + 1);
                nuevoCliente.Nombre = txtNombre.Text;
                nuevoCliente.Apellido = txtApellido.Text;
                nuevoCliente.Nacionalidad = Convert.ToString(cboNac.SelectedValue);

                ClienteService.GetListaCliente().Add(nuevoCliente); 
                this.ClearData();
            } 
            else
            {                           // updating client
                Cliente cli = ClienteService.GetCliente(this.cliente.ID);
                if (cli != null) 
                {
                    this.cliente.Nombre = txtNombre.Text;
                    this.cliente.Apellido = txtApellido.Text;
                    this.cliente.Nacionalidad = Convert.ToString(cboNac.SelectedValue);

                    ClienteService.GetListaCliente().Remove(cli);
                    ClienteService.GetListaCliente().Add(this.cliente);
                    this.ClearData();
                }
            }
        }
    }
}
