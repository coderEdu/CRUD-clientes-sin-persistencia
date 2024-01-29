namespace AppUnidad3.Views.ViewCliente
{
    partial class FormularioCliente
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            cboNac = new ComboBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.7454548F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 30);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 251);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 3;
            label4.Text = "Nacionalidad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(178, 26);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(12, 178);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(178, 26);
            txtApellido.TabIndex = 5;
            // 
            // cboNac
            // 
            cboNac.FormattingEnabled = true;
            cboNac.Location = new Point(12, 273);
            cboNac.Name = "cboNac";
            cboNac.Size = new Size(178, 27);
            cboNac.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 343);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(178, 26);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormularioCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(372, 419);
            Controls.Add(btnGuardar);
            Controls.Add(cboNac);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioCliente";
            Text = "FormularioCliente";
            Load += FormularioCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private ComboBox cboNac;
        private Button btnGuardar;
    }
}