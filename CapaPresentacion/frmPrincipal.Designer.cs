namespace CapaPresentacion
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            ingresoToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            vehiculosToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem1 = new ToolStripMenuItem();
            mecanicoToolStripMenuItem = new ToolStripMenuItem();
            vehiculoToolStripMenuItem = new ToolStripMenuItem();
            facturasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ingresoToolStripMenuItem, consultarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ingresoToolStripMenuItem
            // 
            ingresoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, vehiculosToolStripMenuItem, mantenimientoToolStripMenuItem });
            ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            ingresoToolStripMenuItem.Size = new Size(58, 20);
            ingresoToolStripMenuItem.Text = "Ingreso";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(156, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // vehiculosToolStripMenuItem
            // 
            vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            vehiculosToolStripMenuItem.Size = new Size(156, 22);
            vehiculosToolStripMenuItem.Text = "Vehiculos";
            vehiculosToolStripMenuItem.Click += vehiculosToolStripMenuItem_Click;
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(156, 22);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            mantenimientoToolStripMenuItem.Click += mantenimientoToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem1, mecanicoToolStripMenuItem, vehiculoToolStripMenuItem, facturasToolStripMenuItem });
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(70, 20);
            consultarToolStripMenuItem.Text = "Consultar";
            // 
            // clientesToolStripMenuItem1
            // 
            clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            clientesToolStripMenuItem1.Size = new Size(180, 22);
            clientesToolStripMenuItem1.Text = "Clientes";
            clientesToolStripMenuItem1.Click += clientesToolStripMenuItem1_Click;
            // 
            // mecanicoToolStripMenuItem
            // 
            mecanicoToolStripMenuItem.Name = "mecanicoToolStripMenuItem";
            mecanicoToolStripMenuItem.Size = new Size(180, 22);
            mecanicoToolStripMenuItem.Text = "Mecanico";
            mecanicoToolStripMenuItem.Click += mecanicoToolStripMenuItem_Click;
            // 
            // vehiculoToolStripMenuItem
            // 
            vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            vehiculoToolStripMenuItem.Size = new Size(180, 22);
            vehiculoToolStripMenuItem.Text = "Vehiculo";
            vehiculoToolStripMenuItem.Click += vehiculoToolStripMenuItem_Click;
            // 
            // facturasToolStripMenuItem
            // 
            facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            facturasToolStripMenuItem.Size = new Size(180, 22);
            facturasToolStripMenuItem.Text = "Facturas";
            facturasToolStripMenuItem.Click += facturasToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ingresoToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem1;
        private ToolStripMenuItem mecanicoToolStripMenuItem;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem vehiculosToolStripMenuItem;
        private ToolStripMenuItem vehiculoToolStripMenuItem;
        private ToolStripMenuItem facturasToolStripMenuItem;
    }
}