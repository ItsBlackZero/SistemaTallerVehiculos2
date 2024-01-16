namespace CapaPresentacion
{
    partial class frmFactura
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
            dgvFactura = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            SuspendLayout();
            // 
            // dgvFactura
            // 
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Location = new Point(36, 109);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowTemplate.Height = 25;
            dgvFactura.Size = new Size(656, 310);
            dgvFactura.TabIndex = 0;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 583);
            Controls.Add(dgvFactura);
            Name = "frmFactura";
            Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFactura;
    }
}