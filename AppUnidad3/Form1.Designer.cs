namespace AppUnidad3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            nuevoClienteToolStripMenuItem = new ToolStripMenuItem();
            listarClientesToolStripMenuItem = new ToolStripMenuItem();
            pnlMaster = new Panel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(18, 18);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 26);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { nuevoClienteToolStripMenuItem, listarClientesToolStripMenuItem });
            toolStripDropDownButton1.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Places_user_identity_16;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(89, 23);
            toolStripDropDownButton1.Text = "Clientes";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            nuevoClienteToolStripMenuItem.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_list_add_user_16;
            nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            nuevoClienteToolStripMenuItem.Size = new Size(172, 24);
            nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            nuevoClienteToolStripMenuItem.Click += nuevoClienteToolStripMenuItem_Click;
            // 
            // listarClientesToolStripMenuItem
            // 
            listarClientesToolStripMenuItem.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Apps_preferences_desktop_user_16;
            listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            listarClientesToolStripMenuItem.Size = new Size(172, 24);
            listarClientesToolStripMenuItem.Text = "Listar Clientes";
            listarClientesToolStripMenuItem.Click += listarClientesToolStripMenuItem_Click;
            // 
            // pnlMaster
            // 
            pnlMaster.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMaster.Location = new Point(0, 29);
            pnlMaster.Name = "pnlMaster";
            pnlMaster.Size = new Size(800, 426);
            pnlMaster.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMaster);
            Controls.Add(toolStrip1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de clientes";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private ToolStripMenuItem listarClientesToolStripMenuItem;
        public Panel pnlMaster;
    }
}
