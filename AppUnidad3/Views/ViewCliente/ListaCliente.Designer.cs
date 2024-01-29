namespace AppUnidad3.Views.ViewCliente
{
    partial class ListaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            grdClientes = new DataGridView();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)grdClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.7454548F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 0;
            label1.Text = "Lista de clientes";
            // 
            // grdClientes
            // 
            grdClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdClientes.Location = new Point(12, 59);
            grdClientes.Name = "grdClientes";
            grdClientes.RowHeadersWidth = 47;
            grdClientes.Size = new Size(776, 379);
            grdClientes.TabIndex = 1;
            grdClientes.CellContentClick += grdClientes_CellContentClick;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(702, 14);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 26);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // ListaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualizar);
            Controls.Add(grdClientes);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListaCliente";
            Text = "ListaCliente";
            ((System.ComponentModel.ISupportInitialize)grdClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView grdClientes;
        private Button btnActualizar;
    }
}