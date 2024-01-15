namespace CapaPresentacion
{
    partial class frmConsultarVehiculo
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
            txtConsulta = new TextBox();
            dgvVehiculo = new DataGridView();
            btnAceptar = new Button();
            btnRestaurar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 45);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 0;
            label1.Text = "Consultar vehiculo por placa";
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(54, 73);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(226, 23);
            txtConsulta.TabIndex = 1;
            txtConsulta.TextChanged += txtConsulta_TextChanged;
            txtConsulta.KeyDown += txtConsulta_KeyDown;
            // 
            // dgvVehiculo
            // 
            dgvVehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculo.Location = new Point(311, 50);
            dgvVehiculo.Name = "dgvVehiculo";
            dgvVehiculo.RowTemplate.Height = 25;
            dgvVehiculo.Size = new Size(459, 368);
            dgvVehiculo.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(205, 102);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(124, 102);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(75, 23);
            btnRestaurar.TabIndex = 4;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // frmConsultarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRestaurar);
            Controls.Add(btnAceptar);
            Controls.Add(dgvVehiculo);
            Controls.Add(txtConsulta);
            Controls.Add(label1);
            Name = "frmConsultarVehiculo";
            Text = "frmConsultarVehiculo";
            ((System.ComponentModel.ISupportInitialize)dgvVehiculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtConsulta;
        private DataGridView dgvVehiculo;
        private Button btnAceptar;
        private Button btnRestaurar;
    }
}