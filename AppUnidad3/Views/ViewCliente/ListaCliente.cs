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
using AppUnidad3.Views.ViewCliente;

namespace AppUnidad3.Views.ViewCliente
{
    public partial class ListaCliente : Form
    {
        public ListaCliente()
        {
            InitializeComponent();
            this.ConfigGrid();
            this.LoadClientes();
        }

        private void ConfigGrid()
        {
            DataGridViewButtonColumn actualizar = new DataGridViewButtonColumn();
            DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn();

            actualizar.Name = "Actualizar";
            actualizar.Text = "Actualizar";
            actualizar.HeaderText = "Actualizar";
            actualizar.UseColumnTextForButtonValue = true;

            eliminar.Name = "Eliminar";
            eliminar.Text = "Eliminar";
            eliminar.HeaderText = "Eliminar";
            eliminar.UseColumnTextForButtonValue = true;

            this.grdClientes.Columns.Add("id", "ID");
            this.grdClientes.Columns.Add("nombre", "Nombre");
            this.grdClientes.Columns.Add("apellido", "Apellido");
            this.grdClientes.Columns.Add("nac", "Nacionalidad");
            this.grdClientes.Columns.Add(actualizar);
            this.grdClientes.Columns.Add(eliminar);

            this.grdClientes.Columns["id"].Visible = false;
        }

        public void LoadClientes()
        {
            grdClientes.Rows.Clear();
            foreach (var cli in ClienteService.GetListaCliente())
            {
                grdClientes.Rows.Add(cli.ID, cli.Nombre, cli.Apellido, cli.Nacionalidad);
            }
        }

        private void ActualizarCliente(int? id)
        {
            Cliente cliente = ClienteService.GetCliente(id);

            if (cliente != null)
            {
                CargarFormulario(cliente);
            }
        }

        private void EliminarClientes(int? id)
        {
            Cliente cliente = ClienteService.GetCliente(id);

            if (cliente != null)
            {
                ClienteService.GetListaCliente().Remove(cliente);
            }

            LoadClientes();
        }

        private void CargarFormulario(Cliente cliente)
        {
            Form? parentForm = this.ParentForm as Form;
            if (parentForm == null) { return; }

            Panel? pnlMaster = parentForm.Controls["pnlMaster"] as Panel;
            if (pnlMaster == null) { return; }

            pnlMaster.Controls.Clear();

            Form formulario = new FormularioCliente(cliente);
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            pnlMaster.Controls.Add(formulario);
            formulario.Show();
        }

        private void grdClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdClientes.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                int? id = (int?)grdClientes.Rows[e.RowIndex].Cells["id"].Value;
                ActualizarCliente(id);
            }

            if (grdClientes.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int? id = (int?)grdClientes.Rows[e.RowIndex].Cells["id"].Value;
                EliminarClientes(id);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.LoadClientes();
        }
    }
}
